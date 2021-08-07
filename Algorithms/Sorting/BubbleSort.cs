using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BubbleSort : BaseSort
    {
        public override void Execute(int[] array)
        {
            int n = array.Length;
            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);

            Print(array);
        }
    }
}
