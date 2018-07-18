using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Search
{
    public class JumpSearch : ISearch<int>
    {
        private int[] _data;

        public JumpSearch(int[] arr)
        {
            this._data = arr;
        }

        public int Search(int item)
        {
            ///Algo:
            ///Idea is to start from the 0th index of the array and jump after every certain index.
            ///Check the item to be searched is less than the value at current jumped index. If true
            ///break the loop and perform linear search form the last jumped index to current jumped index.
            ///If item found return index else return -1;


            int returnValue = -1;
            int jump = 3;
            int left = 0;
            int right = left;
            while (right < this._data.Length)
            {
                if (this._data[right] == item)
                {
                    returnValue = right;
                    break;
                }
                else if (this._data[right] < item)
                {
                    left = right;
                    right = left + jump;
                }
                else
                {
                    break;
                }
            }

            if (returnValue == -1)
            {
                int length = this._data.Length < right ? this._data.Length : right;
                for (int i = left; i < length; i++)
                {
                    if (this._data[i] == item)
                    {
                        returnValue = i;
                        break;
                    }
                }
            }

            return returnValue;
        }
    }
}
