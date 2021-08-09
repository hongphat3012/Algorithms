using Algorithms.Assessments;
using Algorithms.Graph;
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

            //algo.Sorting.SelectionSort.Execute(arr);
            //algo.Sorting.BubbleSort.Execute(arr);
            //algo.Sorting.InsertionSort.Execute(arr);

            int[][] matrix = new int[5][] 
            {   new int[5] { 0, 1, 0, 0, 1 }, 
                new int[5] { 1, 0, 1, 1, 1 }, 
                new int[5] { 0, 0, 0, 1, 1 }, 
                new int[5] { 0, 1, 0, 1, 0 }, 
                new int[5] { 1, 0, 0, 0, 0 } 
            };
            //BFS bfs = new BFS();
            //bfs.Execute(matrix);

            NearestZero nearestZero = new NearestZero();
            nearestZero.Execute(matrix);
        }
    }
}
