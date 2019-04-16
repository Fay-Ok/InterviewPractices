using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 8 };
            int target = 6;
            var result = FindInsertIndex(arr, target);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindInsertIndex(int[] arr, int target)
        {
            int result = 0;
            if (arr.Length == 0)
            {
                return 0;
            }
            int start = 0;
            int end = arr.Length - 1;
            if (target > arr[end])
            {
                result = end + 1;
                return result;
            }

            if (target < arr[start])
            {
                result = start;
                return result;
            }

            while (start < end)
            {
                int mid =(end + start) / 2;
                if (arr[mid] == target)
                {
                    result = mid;
                    return result;
                }
                if (arr[mid] < target)
                {
                    if (target > arr[mid + 1])
                    {
                        result = mid;
                        return result;
                    }
                    start = mid;
                }
                else 
                {
                    if (target > arr[mid - 1])
                    {
                        result = mid -1;
                        return result;
                    }
                    end = mid;
                }

               
            }
            return result;
        }
    }
}
