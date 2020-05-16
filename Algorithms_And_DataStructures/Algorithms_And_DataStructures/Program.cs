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

            var pivotIndex = algo.pivot(sample, sample.Length + 1, 0);
            Console.WriteLine(pivotIndex);



            Console.ReadKey();
        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
