using System;
using System.Text;

namespace FindTheLongestPolindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abbatacocat";
            int longetPali = FindTheLongestPolindromeSubstring(str);
            Console.WriteLine("\n"+longetPali);
            Console.ReadLine();
        }

        private static int FindTheLongestPolindromeSubstring(string str)
        {
            int stringLength = str.Length;
            // using two dimention array to be able keep trak of polindroms in substring for example: geeeg ==> two dimantion array helps for "eee"
            bool[,] table = new bool[stringLength, stringLength];

            int maxLength = 1;
            // for substring length one
            for (int i = 0; i < stringLength ; i++)
            {
                table[i,i] = true;
            }
            // for substring length 2
            int start = 0;
            for (int i = 0; i < stringLength - 1; i++)
            {
                if (str[i] == str[i+1])
                {
                    table[i,i + 1] = true;
                    maxLength = 2;
                    start = i;
                }
            }
            // for substring more than 2
            for (int i = 3; i <= stringLength; i++)
            {
                for (int j = 0; j < stringLength - i + 1; j++)
                {
                    int k = j + i - 1;
                    if (table[j + 1, k - 1] && str[j] == str[k] )
                    {
                        table[j, k] = true;
                        if (i > maxLength)
                        {
                            start = j;
                            maxLength = i;
                        }
                    }
                }
            }
            creatPolindromeString(str, start, start + maxLength);

            return maxLength;
        }

        private static void creatPolindromeString(string str, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(str[i]);
            }
        }
    }
}
