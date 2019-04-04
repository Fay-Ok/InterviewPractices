using System;
using System.Collections.Generic;

namespace CountNumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 0, 0, 1, 1, }
            };
            int result = FindNumberOfIslands(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindNumberOfIslands(int[,] matrix)
        {
            int island = 0;

            if (matrix.Length == 0)
            {
                return 0;
            }
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        Islander(matrix, i , j);
                        island++;
                    }
                }
            }

            return island;
        }

        private static void Islander(int[,] matrix, int i, int j)
        {
            Queue<int[]> q = new Queue<int[]>();
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            q.Enqueue(new int[] { i, j });

            while (q.Count != 0)
            {
                int[] position = q.Dequeue();
                int r = position[0];
                int c = position[1];


                if (r + 1 < row && matrix[r + 1 , c] == 1)
                {
                    q.Enqueue(new int[] { r + 1, c });
                }

                if (c + 1 < column && matrix[r,c+ 1] == 1)
                {
                    q.Enqueue(new int[] { r, c + 1 });
                }

                if (c - 1 >=0 &&matrix[r, c - 1] == 1)
                {
                    q.Enqueue(new int[] { r, c - 1 });
                }
                if (r - 1 >= 0 && matrix[r - 1, c] == 1)
                {
                    q.Enqueue(new int[] {r - 1, c });
                }

                matrix[r,c] = 0;
            }
           // return size;
        }
    }
}
