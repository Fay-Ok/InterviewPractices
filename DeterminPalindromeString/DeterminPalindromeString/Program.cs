using System;

namespace DeterminPalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a tacocata";
            bool result = FindPalidromeString(str);
            Console.WriteLine(result);

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
    }
}
