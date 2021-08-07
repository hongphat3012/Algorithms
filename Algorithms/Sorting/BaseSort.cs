using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public abstract class BaseSort
    {
        public abstract void Execute(int[] array);

        public void Print(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        protected void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
