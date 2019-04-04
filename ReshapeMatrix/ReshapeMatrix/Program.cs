using System;
using System.Collections.Generic;

namespace ReshapeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                { 1, 2},
                { 3, 4 },
                { 5, 6 },
                { 7, 8 },

            };
            int x = 2;
            int y = 4;
            ReshapeMatrix(arr, x, y);
            Console.ReadLine();
        }

        private static void ReshapeMatrix(int[,] arr, int x, int y)
        {
            int matrixSize = arr.Length;
            int[,] reshapedmatrix = new int[x,y];
            Queue<int> q = new Queue<int>();

            if (x * y != matrixSize)
            {
                return;
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    q.Enqueue(arr[i, j]);
                    
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                   reshapedmatrix[i,j]= q.Dequeue();

                }
            }
        }
    }
}
