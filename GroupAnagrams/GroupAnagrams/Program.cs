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
            string[] str = new string[] { "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc" };
            IList<IList<string>> l = new List<IList<string>>();
            l = GroupAnagramWords(str);
            DisplayGroupedAnagram(l);
            Console.ReadLine();
        }

        private static IList<IList<string>> GroupAnagramWords(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                char[] c = item.ToCharArray();
                Array.Sort(c);
                string key = new string(c);
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, new List<string> { item});
                }
                else
                {
                    dic[key].Add(item); 
                }
            }

            return dic.Values.ToArray();
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
