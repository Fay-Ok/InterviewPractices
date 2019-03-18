using System;
using System.Linq;

namespace DeterminPalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a tacocata";
            bool result = FindPalidromeString(str);
            bool result2 = FindPalindromeWithUsingArrays(str);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.ReadLine();
        }

        private static bool FindPalidromeString(string str)
        {
            bool isPalindrome = true; ;
            for (int i = 0; i < str.Length / 2 ; i++)
            {
                if (str[i] == ' ')
                {
                    str = str.Remove(i, 1);
                    i--;
                }
                if(str[str.Length - 1 - i] == ' ')
                {
                    str = str.Remove(str.Length - 1 - i, 1);
                    i--;
                }
                if (str[i] != str[str.Length -1 -i] )
                {
                    isPalindrome = false;
                    break;
                }
                
            }
            Console.WriteLine(str);
            return isPalindrome;
        }

        private static bool FindPalindromeWithUsingArrays(string str)
        {
            char[] fromLeft = new char[str.Length];
            char[] fromRight = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                fromLeft[i] = str[i];
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                fromRight[i] = str[i];
            }

            if(fromLeft.SequenceEqual(fromRight))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
