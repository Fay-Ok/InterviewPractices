using System;

namespace SearchA2DMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] {
            { 1,   3,  5,  7},
            {10, 11, 16, 20 },
            {23, 30, 34, 50},
            {60, 65, 68, 70},
            {71, 73, 76, 80},
            {81, 87, 90, 100}
            };

            int target = 5;
            string result = FindTarget(matrix, target);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string FindTarget(int[,] matrix, int target)
        {
            int numberOfRows = matrix.GetLength(0);
            int start = 0;
            int end = numberOfRows -1;

            if (matrix.Length == 0)
            {
                return false.ToString();
            }
            if (matrix[0,0] == target)
            {
                return true.ToString();
            }

            if (matrix[0, 0] > target)
            {
                return false.ToString();
            }
            if (matrix[matrix.GetLength(0) - 1 , matrix.GetLength(1) - 1] == target)
            {
                return true.ToString();
            }

            if (matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] < target)
            {
                return false.ToString();
            }
            int temp = 0;

            while (start < end)
            {
                int mid = start + (end - start)/ 2;
                if (matrix[mid,0] == target)
                {
                    return true.ToString();
                }
                if (target < matrix[mid, 0])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                temp = mid;
            }

            int sC = 0;
            int eC = matrix.GetLength(1) - 1;
            while (sC < eC)
            {
                int mid = sC + (eC - sC) / 2;

                if (matrix[end , mid] == target)
                {
                    return true.ToString();
                }
                if (target < matrix[end - 1, mid])
                {
                    eC = mid - 1;
                }
                else
                {
                    sC = mid + 1;
                }

            }

            return false.ToString();
        }
    }
}
