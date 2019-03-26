using System;
using System.Collections.Generic;
using System.Linq;

namespace SortBasedOnFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 5, 4, 6, 4, 1,1,1,3,4,47,8,89 };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            // insert the frequency in a dictioanry
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else
                {
                    dic[arr[i]] += 1;
                }
            }
            // create a list which holds keys with thier frequency
            List<int> freqList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    int times = dic[arr[i]];
                    for (int j = 0; j < times; j++)
                    {
                        freqList.Add(arr[i]);
                    }
                    dic[arr[i]] = 0;
                }
            }
            // sort the list
            freqList.Sort();
            // print
            for (int i = 0; i < freqList.Count; i++)
            {
                Console.Write(freqList[i]);
            }
            Console.ReadLine();

        }
    }
}
