using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Search
{
    public class LinearSearch : ISearch<int>
    {
        private int[] _data;
        
        public LinearSearch(int[] arr)
        {
            this._data = arr;
        }

        public int Search(int item)
        {
            /// Idea is to traverse each element sequencially in an array until the match is found
      
            if(this._data.Length == 0)
            {
                return -1;
            }

            int itemIndex = -1;

            for (int i = 0; i < this._data.Length; i++)
            {
                if(this._data[i] == item)
                {
                    itemIndex = i;
                    break;       
                }
            }

            return itemIndex;
        }
    }
}
