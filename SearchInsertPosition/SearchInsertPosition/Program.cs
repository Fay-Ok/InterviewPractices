using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3 };
            int target = 5;
            var result = FindInsertIndex(arr, target);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindInsertIndex(int[] arr, int target)
        {

            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    return mid;

                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
