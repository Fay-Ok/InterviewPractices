using System;

namespace FindElementXInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                {10, 20, 30, 40},
               {15, 25, 35, 45},
                {27, 29, 37, 48},
                {32, 33, 39, 50}
            };
            int x = 100;
            string result = FindX(arr,x);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string FindX(int[,] matrix, int x)
        {
            string result = "Not Found";
            if (matrix.Length == 0)
            {
                return "Empty Matrix";
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > x)
                    {
                        break;
                    }
                    if (matrix[i, j] == x)
                    {
                        result = i.ToString() + " " + j.ToString();
                    }
                }
            }
            return result;
        }
    }
}
