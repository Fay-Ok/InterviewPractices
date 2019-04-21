using System;

namespace FindMinimumElementInSortedRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9,7,4,2,1 };
            int result = FindMin(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindMin(int[] args)
        {
            int start = 0;
            int end = args.Length - 1;
            int min = args[0];
            while (start <= end)
            {
                int mid = (start + end) / 2;
                min = Math.Min(args[mid], min);
                if (args[mid] < args[end])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return min;
        }
    }
}
