using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Searching
{
    public class Listy
    {
        private int[] arr;
        private int count;
        public Listy(int length)
        {
            arr = new int[length];
            count = 0;
        }

        public void Push(int value)
        {
            if(count == arr.Length)
            {
                throw new IndexOutOfRangeException();
            }

            arr[count] = value;
            count++;
        }

        public int Pop()
        {
            if(count == 0)
            {
                throw new InvalidOperationException();
            }

            count--;
            return arr[count];
        }

        public int ElementAt(int index)
        {
            if(count <= index || index < 0)
            {
                return -1;
            }

            return arr[index];
        }
    }
    public class SortedSearchNoSize
    {
        private Listy obj;

        public SortedSearchNoSize(int[] arr)
        {
            obj = new Listy(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                obj.Push(arr[i]);
            }
        }

        public int Search(int target)
        {
            int length = FindLength();
            int returnValue = BinarySearch(target, 0, length - 1);

            return returnValue;
        }

        private int FindLength()
        {
            int leftBound = 0;
            int rightBound = 2;

            while(obj.ElementAt(rightBound) != -1)
            {
                leftBound = rightBound;
                rightBound = rightBound * 2;
            }

            while (leftBound <= rightBound)
            {
                int mid = (leftBound + rightBound) / 2;

                if (obj.ElementAt(mid) == -1)
                {
                    rightBound = mid - 1;
                }
                else
                {
                    leftBound = mid + 1;
                }
            }

            return System.Math.Max(leftBound, rightBound);
        }

        private int BinarySearch(int target, int left, int right)
        {
            while(left <= right)
            {
                int mid = (left + right) / 2;

                if(obj.ElementAt(mid) == target)
                {
                    return mid;
                }
                else if(obj.ElementAt(mid) < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
