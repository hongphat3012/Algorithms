using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Algorithm
    {
        private SortingAlgorithm _sorting;
        public SortingAlgorithm Sorting
        {
            get
            {
                if(this._sorting == null)
                {
                    this._sorting = new SortingAlgorithm();
                }
                return this._sorting;
            }
        }
    }
}
