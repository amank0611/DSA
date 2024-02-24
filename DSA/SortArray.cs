using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA
{
    internal class SortArray
    {
        public static void MergeTwoSortedArray()
        {
            //Input: arr1[] = { 1, 3, 4, 5 }, arr2[] = { 2, 4, 6, 8 }
            //Output: arr3[] = { 1, 2, 3, 4, 4, 5, 6, 8 }
            int[] arr1 = { 1, 3, 4, 5 }; 
            int[] arr2 = { 2, 4, 6, 8 };
            int[] arr3 = [];

           

        }
        public static void GetSortArray()
        {
            int[] a = [1, 4, 5, 7];
            int[] b = [2, 3, 6];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {

                }
            }

            Array.Sort(a);
            Array.Sort(b);
            //Console.WriteLine($"sorted array is: {string.Join(",", a)}");
            //Console.WriteLine($"sorted array is: {string.Join(",", b)}");

            Console.WriteLine("Sorted array1:");
            PrintArray(a);

            Console.WriteLine("Sorted array2:");
            PrintArray(b);
        }
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
