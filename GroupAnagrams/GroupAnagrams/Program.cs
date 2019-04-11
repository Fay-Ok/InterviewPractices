using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[]{ "eat", "tea", "tan", "ate", "nat", "bat"};
            IList<IList<string>> ll = new List<IList<string>>();
            ll= GroupAnagrams(str);

            DisplayGroupedAnagram(ll);
            Console.ReadLine();
        }



        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();

            foreach (var item in strs)
            {
                dic = GroupsAnagrams(item, dic);
            }

            return dic.Values.ToArray(); ;
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
                dic.Add(sum, new List<string> { item });

            }
            else
            {
                dic[sum].Add(item);

            }

            return dic;
        }

        private static void DisplayGroupedAnagram(IList<IList<string>> dic)
        {
            List<string> l = new List<string>();
            foreach (var item in dic)
            {
                l = item.Select(a => a).ToList();
                foreach (var value in l)
                {
                    Console.Write(value + " ");
                }
                Console.Write("\n");
            }
           
            
        }
    }
}
