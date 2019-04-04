using System;
using System.Collections.Generic;
using System.Linq;

namespace FindThebiggestIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] {
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 0, },
                { 1, 1, 1, 1, },
                { 1, 1, 1, 1, }
            };
            int result = FindBiggestOfIslands(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindBiggestOfIslands(int[,] matrix)
        {
            int max = 0;
            bool[,] visited = new bool[matrix.GetLength(0),matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        int result = FindBiggest(matrix, visited, i, j);
                        max = Math.Max(max, result);
                    }
                }
            }
            return max;
        }

        private static int FindBiggest(int[,] matrix, bool[,] visited,int i, int j)
        {
            int size = 0;

            Queue<int[]> q = new Queue<int[]>();
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            q.Enqueue(new int[] { i, j });
            visited[i, j] = true;

            while (q.Count != 0)
            {
                int[] location = q.Dequeue();
                int r = location[0];
                int c = location[1];

                if (r + 1 < row && !visited[r + 1, c] && matrix[r+ 1,c] == 1)
                {
                    visited[r + 1, c] = true;
                    q.Enqueue(new int[] { r + 1, c });
                }

                if (r - 1 >= 0 &&  !visited[r - 1, c] &&  matrix[r - 1, c] == 1)
                {
                    visited[r - 1, c] = true;
                    q.Enqueue(new int[] { r - 1, c });
                }
                if (c + 1 < column &&  !visited[r , c + 1] && matrix[r, c + 1] == 1)
                {
                    visited[r, c + 1] = true;
                    q.Enqueue(new int[] { r, c + 1 });
                }
                if (c - 1 >= 0 &&  !visited[r, c - 1] &&  matrix[r , c - 1] == 1)
                {
                    visited[r, c - 1] = true;
                    q.Enqueue(new int[] { r, c - 1 });
                }
                size++;

                matrix[r, c] = 0;
            }

            return size;
        }
    }
}
