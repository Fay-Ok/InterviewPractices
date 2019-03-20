using System;

namespace DetermineSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determine by swaping and removing one element from the array, the array would be sorted
            int[] intArr = new int[] { 5, 3, 4, 2 };
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
                    if (counter == 0)
                    {
                        left = i;
                    }
                    if (counter == 1)
                    {
                        right = i + 1;

                    }
                    counter++;

                }

            }

            if (counter == 1)
            {
                isSorted = true;
            }

            if (counter == 2)
            {
                bool foundOne = false;
                int temp = intArr[left];
                intArr[left] = intArr[right];
                intArr[right] = temp;
                for (int i = 0; i < intArr.Length - 1; i++)
                {
                    if (intArr[i] > intArr[i + 1])
                    {
                        foundOne = true;
                        break;
                    }
                }
                if (!foundOne)
                {
                    isSorted = true;

                }
            }
            if (counter > 3)
            {
                isSorted = false;
            }

            return isSorted;
        }
    }
}
