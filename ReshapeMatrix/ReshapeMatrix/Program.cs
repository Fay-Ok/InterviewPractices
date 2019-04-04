using System;

namespace ReshapeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                { 1, 2},
                { 3, 4 },
             
            };
            int x = 1;
            int y = 4;
            ReshapeMatrix(arr, x, y);
            Console.ReadLine();
        }

        private static void ReshapeMatrix(int[,] arr, int x, int y)
        {
            int matrixSize = arr.Length;
            int[,] reshapedmatrix = new int[x,y];
            if (x * y != matrixSize)
            {
                return;
            }
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    reshapedmatrix[a, b] = arr[i, j];
                    if (a < x -1 )
                    {
                        a++;
                    }
                    if (b < y -1)
                    {
                        b++;
                    }
                }
            }
        }
    }
}
