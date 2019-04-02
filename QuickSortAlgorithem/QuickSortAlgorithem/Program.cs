using System;

namespace QuickSortAlgorithem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            QickSort(arrayOfInt, 0, arrayOfInt.Length - 1);
            printSortedArray(arrayOfInt);
            Console.ReadLine();

        }

        private static void QickSort(int[] arrayOfInt, int left, int right)
        {
            if(left>= right)
            {
                return;
            }

            int index = arrayOfInt[(left + right) / 2];
            int partition = Partition(arrayOfInt, left, right, index);
            QickSort(arrayOfInt, left, partition - 1);
            QickSort(arrayOfInt, partition, right);
           
        }

        private static void printSortedArray(int[] arrayOfInt)
        {
            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                Console.WriteLine(arrayOfInt[i]);

            }
        }

        private static int Partition(int[] arrayOfInt, int left, int right, int pivot)
        {
           

            while (left< right)
            {
                while (arrayOfInt[left] < pivot)
                {
                    left++;
                }
                while (arrayOfInt[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = arrayOfInt[left];
                    arrayOfInt[left] = arrayOfInt[right];
                    arrayOfInt[right] = temp;
                    right--;
                    left++;
               
                }
            }
            return left;
        }
    }
}
