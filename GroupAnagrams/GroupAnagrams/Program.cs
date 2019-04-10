using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[]{ "eat", "tea", "tan", "ate", "nat", "bat"};
            Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();

            foreach (var item in str)
            {
              dic =   GroupsAnagrams(item, dic);
            }

            DisplayGroupedAnagram(dic);
            Console.ReadLine();
        }

        private static void DisplayGroupedAnagram(Dictionary<int, List<string>> dic)
        {
            foreach (KeyValuePair<int, List<string>> keySum in dic)
            {
                Console.Write(keySum.Key + " ");
                foreach (string value in keySum.Value)
                {
                    Console.Write(value + " ");
                }
                Console.Write("\n");
            }
        }

        private static Dictionary<int, List<string>> GroupsAnagrams(string item, Dictionary<int, List<string>> dic)
        {
            int sum = 0;
            for (int i = 0; i < item.Length; i++)
            {
                sum += item[i] - 'a';
            }
            if (!dic.ContainsKey(sum))
            {
                dic.Add(sum,new List<string> { item });
            }
            else
            {
                dic[sum].Add(item);
            }

            return dic;
        }
       
    }
}
