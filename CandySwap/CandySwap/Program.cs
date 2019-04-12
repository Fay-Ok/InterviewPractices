using System;
using System.Collections.Generic;
using System.Linq;

namespace CandySwap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 1, 2 };
            List<int> B = new List<int> { 2, 3 };
            Dictionary<string, int> exchangedCandy = new Dictionary<string, int>();
            exchangedCandy = CandySwap(A, B , exchangedCandy);
            foreach (var item in exchangedCandy)
            {
                Console.Write(item.Key +" " + item.Value);

            }
            Console.ReadLine();
        }

        private static Dictionary<string, int> CandySwap(List<int> a, List<int> b, Dictionary<string, int> exchangedCandy)
        {
            int ASize = a.Sum();
            int BSize = b.Sum();
            int sum = ASize + BSize;
            int diff = 0;
            int sumOfBandA = 0;
            for (int i = 0; i < a.Count; i++)
            {
                sumOfBandA = BSize + a[i];
                if (sumOfBandA > sum /2)
                {
                    ASize -= a[i];
                    BSize += a[i];
                    a.Remove(a[i]);

                    if (!exchangedCandy.ContainsKey("a"))
                    {
                        exchangedCandy.Add("a", a[i]);
                    }
                    else
                    {
                        exchangedCandy["a"] = a[i];
                    }
                    diff = Math.Abs(sumOfBandA - sum / 2);
                    b.Add(a[i]);
                    
                   
                }
               
            }

            for (int i = 0; i < b.Count; i++)
            {

                if (b[i] == diff && (ASize + b[i] == sum/2) &&(BSize - b[i] == sum / 2))
                {
                    b.Remove(b[i]);
                    if (!exchangedCandy.ContainsKey("b"))
                    {
                        exchangedCandy.Add("b", b[i]);

                    }
                    else
                    {
                        exchangedCandy["b"] = b[i];
                    }
                }
            }

            return exchangedCandy;
        }

    }
}
