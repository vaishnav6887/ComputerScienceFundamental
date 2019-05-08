using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.String
{
    /// <summary>
    /// Cracking coding interview : Problem 1.2 Check Permutation: 
    /// Given two strings, write a method to decide if one is a permutation of the other
    /// </summary>
    public static class CheckStringsArePermutation
    {
        public static bool CheckPermutation(string argA, string argB)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int index = 0; index < argA.Length; index++)
            {
                int currentValue = (int)argA[index];
                int currentValueTotal = 0;

                if(map.ContainsKey(currentValue))
                {
                    currentValueTotal = map[currentValue];
                }
                else
                {
                    map.Add(currentValue, currentValueTotal);
                }

                currentValueTotal++;

                map[currentValue] = currentValueTotal;
            }

            for(int index = 0; index < argB.Length; index++)
            {
                int currentValue = (int)argB[index];
                if(map.ContainsKey(currentValue))
                {
                    int cur = map[currentValue] - 1;
                    
                    if(cur == 0)
                    {
                        map.Remove(currentValue);
                    }
                    else
                    {
                        map[currentValue] = cur;
                    }
                }
                else
                {
                    return false;
                }
            }

            return map.Count == 0;
        }
    }
}
