using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSort : BaseSort
    {
        /// <summary>
        /// 1. Start with the second element of the array (i = 1)
        /// 2. At each element, compare the key with previous elements
        /// 3. If the key is smaller than the predecessor, insert the key into it's position
        /// </summary>
        /// <param name="array"></param>
        public override void Execute(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            Print(array);
        }
    }
}
