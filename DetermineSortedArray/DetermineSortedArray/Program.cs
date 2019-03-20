using System;

namespace DetermineSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determine by swaping and removing one element from the array, the array would be sorted
            int[] intArr = new int[] { 1, 10, 3, 4, 5 };
            bool isSorted = isArraySorted(intArr);
            Console.WriteLine(isSorted);
            Console.ReadLine();

        }

        private static bool isArraySorted(int[] intArr)
        {
            bool isSorted = false;
            int counter = 0;
            int left = 0;
            int right = 0;

            for (int i = 0; i < intArr.Length -1 ; i++)
            {
                if (intArr[i] > intArr[i+1])
                {
                    counter++;
                }

                if (counter == 2)
                {
                    left = i;
                    right = i + 1;
                }
   
                
            }

            if (counter == 1)
            {
                isSorted = true;
            }

            if (counter == 2)
            {

            }
            if (counter > 3)
            {
                isSorted = false;
            }

            return isSorted;
        }
    }
}
