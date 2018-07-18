using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Math
{
    public static class MathProblems
    {

        /// <summary>
        /// Not working
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<int> PrimeNumber(int max)
        {
            /// Algorithm
            /// Step 1: create a list of all the number between 2(first prime number) and max
            /// Step 2: start with the first index i.e. 2 mark all the element in the array which are divisible by 2 as visited.
            /// step 3: move next unvisited number i.e 3 and find all the number which are divisible by 3 and mark them visited.
            /// Step 4: Continue with the every unvisited number till unvisited number is less than max

            int[] input = new int[max];

            /// Step 1
            for (int i = 0; i < max; i++)
            {
                input[i] = i;
            }

            List<int> returnValue = new List<int>();
            
            foreach (var item in input)
            {
                if(IsPrime(item))
                {
                    returnValue.Add(item);
                }
            }

            return returnValue;
        }

        private static bool IsPrime(int item)
        {
            if(item < 2)
            {
                return false;
            }
            
            if(item == 2)
            {
                return true;
            }

            bool prime = true;
            for (int i = 2; i < item; i++)
            {
                if(item % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
