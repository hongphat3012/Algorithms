using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SortingAlgorithm
    {
        private BubbleSort _bubbleSort;
        public BubbleSort BubbleSort
        {
            get
            {
                if(this._bubbleSort == null)
                {
                    this._bubbleSort = new BubbleSort();
                }
                return this._bubbleSort;
            }
        }

        private InsertionSort _insertionSort;
        public InsertionSort InsertionSort
        {
            get
            {
                if (this._insertionSort == null)
                {
                    this._insertionSort = new InsertionSort();
                }
                return this._insertionSort;
            }
        }

        private SelectionSort _selectionSort;
        public SelectionSort SelectionSort
        {
            get
            {
                if (this._selectionSort == null)
                {
                    this._selectionSort = new SelectionSort();
                }
                return this._selectionSort;
            }
        }
    }
}
