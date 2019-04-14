using System;
using System.Collections;
using System.Collections.Generic;

namespace FindPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 6, 9, 10, 20 };
            Dictionary<int, int> l = new Dictionary<int, int>();
            l = FindPerfectSquareOfSum(arr);

            foreach (var item in l)
            {
                Console.Write(item);
            }
            Console.Read();
        }

        private static Dictionary<int, int> FindPerfectSquareOfSum(int[] arr)
        {
            HashSet<int> nums = new HashSet<int>();
            List<int> perfectSquare = new List<int>();
            int twoMaxNum = FindTwomaxNum(arr);
            List<int> perfectSquareList = GetPerfectSquares(twoMaxNum);
            Dictionary<int, int> l = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                nums.Add(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < perfectSquareList.Count; j++)
                {
                    var diff = perfectSquareList[j] - arr[i];
                    if (diff > arr[i] && nums.Contains(diff))
                    {
                        l.Add(diff, arr[i]);
                    }

                }
            }
            return l;
        }
        private static int FindTwomaxNum(int[] arr)
        {
            int firstMax = 0;
            int secMax = 0;

            if (arr[0] > arr[1])
            {
                firstMax = arr[0];
                secMax = arr[1];
            }
            else
            {
                firstMax = arr[1];
                secMax = arr[0];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > firstMax)
                {
                    secMax = firstMax;
                    firstMax = arr[i];
                }
            }
            return firstMax + secMax;
        }

        private static List<int> GetPerfectSquares(int twoMaxNum)
        {
            List<int> nums = new List<int>();
            int m = (int)Math.Floor(Math.Sqrt(twoMaxNum));
            for (int i = 1; i <= m; i++)
            {

                nums.Add(i * i);
            }

            return nums;
        }
        private static Dictionary<int, int> GetPairsWithPerfectSquare(int item, List<int> perfectSquareList, HashSet<int> nums)
        {
            Dictionary<int, int> l = new Dictionary<int, int>();
            int counter = 0;
            for (int i = 0; i < perfectSquareList.Count; i++)
            {
                var diff = perfectSquareList[i] - item;
                if (diff > item && nums.Contains(diff))
                {
                    l.Add(diff,item);
                    counter++;
                }
                
            }
            return l;
        }

    }
}
