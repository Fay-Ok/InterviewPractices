using System;
using System.Collections.Generic;

namespace SortBinaryArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 0, 1, 1, 1, 1, 1, 0, 0, 0 };
            sortArray(intArray);
            Console.ReadLine();
        }

        private static void sortArray(int[] intArray)
        {
            List<int> arrayOfZerro = new List<int>() { };
            List<int> arrayOfOne = new List<int>() { };
            for (int i = 0; i < intArray.Length - 1 ; i++)
            {
                if (intArray[i] == 0)
                {
                    arrayOfZerro.Add(0);
                }
                else
                {
                    arrayOfOne.Add(1);
                }
                
               
            }
            arrayOfZerro.AddRange(arrayOfOne);
            for (int i = 0; i < arrayOfZerro.Count; i++)
            {
                Console.Write(arrayOfZerro[i] + " ");

            }
        }
    }
}
