using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.BitManipulation
{
    public class MaxNumberWithoutComparison
    {
        public bool IsPositive(int num1)
        {
            int result = num1 >> 31;

            return Convert.ToBoolean(result + 1);
        }
    }
}
