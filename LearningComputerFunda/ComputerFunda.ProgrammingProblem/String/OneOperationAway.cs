using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.String
{
    /// <summary>
    /// Cracking coding interview: Problem 1.5 : One Away (Easy)
    /// </summary>
    public class OneOperationAway
    {
        public bool IsOneAway(string argA, string argB)
        {
            int max = System.Math.Max(argA.Length, argB.Length) - System.Math.Min(argA.Length, argB.Length);

            if(max > 1)
            {
                return false;
            }

            int a = 0;
            int b = 0;
            int skip = 0;
            while (a < argA.Length && b < argB.Length)
            {
                if(argA.ElementAt(a) != argB.ElementAt(b))
                {
                    skip++;

                    if(max == 0)
                    {
                        b++;
                    }
                }
                else
                {
                    b++;
                }

                a++;
            }

            return skip <= 1;
        }
    }
}
