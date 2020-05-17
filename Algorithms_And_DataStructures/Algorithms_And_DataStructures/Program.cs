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

            //var quickSort = algo.QuickSort(sample, 0, sample.Length - 1);
            //printArray(quickSort);

            printArray(algo.RadixSort(new[] {23, 234, 5467, 12, 2345, 9852}));

            Console.ReadKey();
        }

        static void printArray(int[] arr)
        {
            Debug.WriteLine(string.Join(", ", arr));
        }
    }
}
