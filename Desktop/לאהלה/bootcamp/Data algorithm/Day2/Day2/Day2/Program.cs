using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 987, 3, 2, 5, 4, 80, 67, 9,68 };
            MergeSort.sort(arr,0, arr.Length-1);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+" ");
            Console.WriteLine(BinarySearch.BSearch(arr, 2, 0, arr.Length-1));
            Console.ReadLine();

        }

    }
}
