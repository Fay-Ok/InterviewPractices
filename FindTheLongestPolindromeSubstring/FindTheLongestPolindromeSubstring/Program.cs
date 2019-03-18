using System;
using System.Text;

namespace FindTheLongestPolindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abbacdtacocat";
            string longetPali = FindTheLongestPolindromeSubstring(str);
            Console.WriteLine(longetPali);
            Console.ReadLine();
        }

        private static string FindTheLongestPolindromeSubstring(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string result = "";
            int start = 0;
            int end = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                int leftLoop = str.Length - i - 1;
                if (start < leftLoop &&  str[start] == str[leftLoop])
                {
                    stringBuilder.Append(str[start]);
                    end = str.Length - i - 1;
                    while (start < end)
                    {
                        if (str[start] == str[end])
                        {
                            start++;
                            stringBuilder.Append(str[start]);
                            end--;

                        }

                    }

                    stringBuilder.Append(str[str.Length - i - 1]);

                }

            }

            if (result.Length < stringBuilder.Length)
            {
                result = stringBuilder.ToString();
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
