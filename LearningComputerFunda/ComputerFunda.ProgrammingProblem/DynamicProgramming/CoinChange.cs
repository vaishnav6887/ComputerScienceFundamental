using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.DynamicProgramming
{
    public class CoinChange
    {
        public int GetMeChange(int money, int n)
        {
            Dictionary<int, int> memorization = new Dictionary<int, int>();
            memorization.Add(0, 0);
            return MinCountForChange(money, memorization, n);
        }

        private int MinCountForChange(int money, Dictionary<int, int> memorization, int n)
        {
            if (memorization.ContainsKey(money))
            {
                return memorization[money];
            }
            else
            {
                int returnMoney = Int32.MaxValue;
                for (int i = 1; i <= n; i++)
                {
                    if (i <= money)
                        returnMoney = System.Math.Min(returnMoney, MinCountForChange(money - i, memorization, n)) + 1;
                }

                memorization.Add(money, returnMoney);
                return returnMoney;
            }
        }
    }
}
