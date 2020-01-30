using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.DynamicProgramming
{
    public class KnapSnack
    {
        public List<int> _weights { get; set; }
        public List<int> _profits { get; set; }
        public int _capacity { get; set; }
        public int _maxProfit { get; set; }
        public KnapSnack(List<int> weights, List<int> profits, int capacity)
        {
            _capacity = capacity;
            _weights = weights;
            _profits = profits;
            _maxProfit = 0;
        }

        public int Calculate(int remainingCapacity, int currentWeight = 0, int currentProfit = 0, int index = 0)
        {
            if(remainingCapacity <= 0 || index >= _weights.Count)
            {
                return currentProfit;
            }

            int newWeight = currentWeight + _weights[index];

            int withCurrent = 0;
            int withOutCurrent = 0;

            if(newWeight <= _capacity)
                withCurrent = Calculate(remainingCapacity - _weights[index], newWeight, currentProfit + _profits[index], index + 1);

            withOutCurrent = Calculate(remainingCapacity, currentWeight, currentProfit, index + 1);

            _maxProfit = System.Math.Max(_maxProfit, System.Math.Max(withCurrent, withOutCurrent));

            return System.Math.Max(withCurrent, withOutCurrent);
        }
    }
}
