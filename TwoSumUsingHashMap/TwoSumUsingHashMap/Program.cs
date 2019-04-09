using System;
using System.Collections.Generic;

namespace TwoSumUsingHashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 11, 15 };
            int target = 18;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dic.Add(arr[i], i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var compliment = target - arr[i];
                if (dic.ContainsKey(compliment))
                {
                    Console.WriteLine("the indices of two numbers: [" + dic[compliment] +", " + i + "]");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
