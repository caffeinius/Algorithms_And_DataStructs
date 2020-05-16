using System;
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
        public int pivot(int[] arr, int start, int end)
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
