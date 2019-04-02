using System;

namespace FindPercentageOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 1, }
            };
            double result = FindPercentageOfMatirxIsOne(arr);
            Console.WriteLine(result * 100);
            Console.ReadLine();
                       
        }

        public static double FindPercentageOfMatirxIsOne(int[,] matrix)
        {
            double ones = 0.0;
            int elements = matrix.Length;
            if (matrix.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        ones++;
                    }
                }
            }

            return (ones / elements);
        }
    }
}
