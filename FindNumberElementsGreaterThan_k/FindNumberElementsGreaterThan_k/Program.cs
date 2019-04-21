using System;

namespace FindNumberElementsGreaterThan_k
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 3, 4, 7, 7, 7, 11, 13, 13 };
            int target = 7 ;
            int result = FindNumberElements(arr, target);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindNumberElements(int[] arr, int target)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            int start = 0;
            int end = arr.Length - 1;
            int index = arr.Length;

            if (target > arr[end])
            {
                return 0;
            }
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] > target)
                {
                    index = mid;
                    end = mid - 1;
                }
                else
                {
                    
                    start = mid + 1;

                }
            }
            return arr.Length - index;

        }
    }
}
