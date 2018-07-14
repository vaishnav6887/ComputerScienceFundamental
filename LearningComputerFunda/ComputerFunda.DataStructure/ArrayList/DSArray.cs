using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.ArrayList
{
    public class DSArray<T>
    {
        public T[] _data;

        public int Count { get; set; }

        public DSArray(int size)
        {
            _data = new T[size];

            this.Count = size;
        }

        public void ReverseRotate(int index)
        {
            Reverse(0, index - 1);
            Reverse(index, this.Count - 1);
            Reverse(0, this.Count-1);
        }

        public Dictionary<T, int> FindFrequencyOfElement()
        {
            Dictionary<T, int> value = new Dictionary<T, int>();

            int i = 0;
            while (this._data.Length > i)
            {
                var key = this._data[i];
                if (value.ContainsKey(key))
                {
                    value[key] += 1; 
                }
                else
                {
                    value.Add(key, 1);

                }

                i++;
            }

            return value;
        }

        public void FindFrequencyWithOutExtraSpace(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[arr[i] % n] = arr[arr[i] % n] + n;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + 1 + "->" + arr[i] / n);
            }
        }

        private void Reverse(int start, int end)
        {
            while(start < end)
            {
                T swap = this._data[start];
                this._data[start] = this._data[end];
                this._data[end] = swap;

                end--;
                start++;
            }
        }
    }
}
