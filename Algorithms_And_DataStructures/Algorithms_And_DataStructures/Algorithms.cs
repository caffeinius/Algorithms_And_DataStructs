using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class Algorithms
    {
        public int[] RadixSort(int[] arr)
        {
            var mostDigitCount = MostDigits(arr);
            for (int k = 0; k < mostDigitCount; k++)
            {
                //var digitBuckets = new int[10][];
                //for (var i = 0; i < arr.Length; i++)
                //{ 
                //    digitBuckets[i] = new int[]{};
                //    var digit = (int)GetDigit(arr[i], k);
                //    digitBuckets[digit][i] = arr[i];
                //}
                //Array.Copy(digitBuckets, arr, digitBuckets.Length);

                // create an array of arrays
                var digitBuckets = new List<List<double>>(); // or double[]

                //for each number in arr...
                for (int i = 0; i < arr.Length; i++)
                {
                    //get the digit in the place k
                    var digit = GetDigit(arr[i], k);

                    //add it to the digit bucket
                    //digitBuckets.Insert(digit, ); 
                }

                //put the numbers back into arr in the order they were added to the digit bucket
                
            }
            return arr;
        }
        public double GetDigit(int num, double place)
        {
            var baseNum = Math.Abs(num);
            var power = Math.Pow(10.0, place);

            var result = Math.Floor((baseNum / power) % 10);
            return result;
        }

        private double DigitCount(int num)
        {
            if (num == 0) return 1;
            return Math.Floor(Math.Log10(Math.Abs(num))) + 1;
        }

        public double MostDigits(int[] nums)
        {
            double mostDigits = 0;
            foreach (var num in nums)
            {
                mostDigits = Math.Max(mostDigits, DigitCount(num));
            }

            Debug.WriteLine($"MostDigits: {mostDigits}");

            return mostDigits;
        }

        public int[] QuickSort(int[] arr, int left, int right)
        {
            //var pivotIndex = pivot(arr, 0, arr.Length + 1);
            var pivotIndex = pivot(arr, left, right);

            if (left < right)
            {

                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }

            return arr;
        }
        private int pivot(int[] arr, int start, int end)
        {
            var pivot = arr[start]; //actual value
            var swapIdx = start; // keep track of where we're putting the value we're going to move to

            for (int i = start + 1; i < arr.Length; i++)
            {
                Debug.WriteLine($"swapIdx: {swapIdx}, i: {i}");
                if (pivot > arr[i])
                {
                    swapIdx++;
                    swap(arr, swapIdx, i);
                }
                printArray(arr);
            }
            swap(arr, start, swapIdx);

            return swapIdx;
        }

        private void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void printArray(int[] arr)
        {
            Debug.WriteLine(string.Join(", ", arr));
        }
    }
}
