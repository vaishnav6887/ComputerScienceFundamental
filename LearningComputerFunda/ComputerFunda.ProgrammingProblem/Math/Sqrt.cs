using System;
using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.Math
{
    public class Sqrt
    {
        public int CalculateSqrt(int num)
        {
            List<int> count = new List<int>();
            int left = 1;
            int right = Convert.ToInt32(System.Math.Floor(Convert.ToDouble(num / 2)));
            while(left <= right)
            {
                
                int mid = Convert.ToInt32(System.Math.Floor(Convert.ToDouble((left + right) / 2)));
                count.Add(mid);
                if (mid * mid == num)
                {
                    return mid;
                }

                if(mid * mid < num)
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
