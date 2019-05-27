using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Math
{
    public class NumberSwapper
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public NumberSwapper(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void SwapInPlace()
        {
            Num1 = Num1 + Num2;
            Num2 = Num1 - Num2;
            Num1 = Num1 - Num2;
        }
    }
}
