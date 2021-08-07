using Algorithms.Sorting;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 33, 27, 10, 35, 19, 42, 44 };
            Algorithm algo = new Algorithm();

            algo.Sorting.SelectionSort.Execute(arr);
            //algo.Sorting.BubbleSort.Execute(arr);
            //algo.Sorting.InsertionSort.Execute(arr);
        }
    }
}
