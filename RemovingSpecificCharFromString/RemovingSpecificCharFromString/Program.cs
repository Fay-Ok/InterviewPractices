using System;
using System.Text;

namespace renoveGivenChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcadae";
            string expectedResult = "bcde";
            char removeChar = 'a';
            string result = CharacterRemover(str, removeChar);
            if (result == expectedResult)
            {
                Console.WriteLine("True");
                Console.WriteLine(result);
            }

            string result2 = characterRemovalWithoutStringBuilder(str, removeChar);
            if (result2 == expectedResult)
            {
                Console.WriteLine("True");
                Console.WriteLine(result2);
            }

            Console.ReadLine();
        }

        private static string CharacterRemover(string str, char removeChar)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != removeChar)
                {
                    stringBuilder.Append(str[i]);

                }
            }
            return stringBuilder.ToString();
        }

        private static string characterRemovalWithoutStringBuilder(string str, char removeChar)
        {
            if (str.Length == 0)
            {
                return null;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == removeChar)
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;

        }
    }
}
