using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo = new Algorithms();
            int[] sample = new[] {4, 8, 2, 1, 5, 7, 6, 3};

            //var pivotIndex = algo.pivot(sample, 0, sample.Length + 1);
            //Console.WriteLine(pivotIndex);

            var quickSort = algo.QuickSort(sample, 0, sample.Length - 1);
            printArray(quickSort);

            Console.ReadKey();
        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
