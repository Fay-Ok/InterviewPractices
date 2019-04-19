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

            int target = 9;
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
            int midR = 0;
            int columns = matrix.GetLength(1) - 1;
            while (start <= end)
            {
                 midR = (start+ end )/ 2;
                if (target >= matrix[midR,0] && target <= matrix[midR,columns])
                {
                    break;
                }
                if (target < matrix[midR, 0])
                {
                    end = midR -1 ;
                }
                else
                {
                    start = midR + 1;
                }
            }

            int sC = 0;
            int eC = matrix.GetLength(1) - 1;
            while (sC <= eC)
            {
                int midC = (sC + eC)/ 2;

                if (matrix[midR, midC] == target)
                {
                    return true.ToString();
                }
                if (target < matrix[midR, midC])
                {
                    eC = midC - 1;
                }
                else
                {
                    sC = midC + 1;
                }

            }

            return false.ToString();
        }

    //    int start = 0;

    //    int m = matrix.Length, n = matrix.GetLength(0), lo = 0, hi = m * n - 1, mi, row, col;
    //    int end = matrix.Length * matrix.GetLength(0) - 1;
    //        while (start <= end)
    //        {
    //            mi = lo + ((hi - lo) >> 1);
    //            row = mi / n;
    //            col = mi % n;

    //            int mid = matrix[((start + end) / 2) / matrix.GetLength(0), ((start + end) / 2) % matrix.GetLength(0)];
    //            if (mid== target)
    //            {
    //                return true.ToString();
    //}
    //            if (mid > target)
    //            {
    //                start = mid + 1;
    //            }
    //            else
    //            {
    //                end = mid - 1;
    //            }
    //        }
    //        return false.ToString();
 
    }
}
