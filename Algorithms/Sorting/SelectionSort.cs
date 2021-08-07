using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort : BaseSort
    {
        public override void Execute(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                int smallest = i;
                for(int j = i + 1; j < n; j++)
                {
                    if(array[smallest] > array[j])
                    {
                        smallest = j;
                    }
                }

                Swap(array, i, smallest);
            }

            Print(array);
        }
    }
}
