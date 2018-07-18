using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Search
{
    public class BinarySearch : ISearch<int>
    {
        private int[] _data;

        public BinarySearch(int[] arr)
        {
            this._data = arr;
        }

        public int Search(int item)
        {
            /// Idea is to find the center of the number and then verify if the center number is equal to item to be searched if small then add 
            /// find the mid of left part 
            /// else find the mid of right part
            /// recursively keep on find the mid until the item to be searched is found or all the items in array are visited.
            
            if(this._data == null || this._data.Length == 0)
            {
                return -1;
            }

            int mid = Convert.ToInt32(Math.Round(Convert.ToDouble(this._data.Length / 2)));
            int left = 0;
            int right = this._data.Length - 1;

            while(this._data[mid] != item && right != left)
            {
                if(this._data[mid] > item)
                {
                    right = mid - 1; 
                }

                if(this._data[mid] < item)
                {
                    left = mid + 1;
                }

                mid = Convert.ToInt32(Math.Round(Convert.ToDouble((right + left) / 2)));
            }

            int index = -1;

            if(this._data[mid] == item)
            {
                index = mid;
            }

            return index;
        }
    }
}
