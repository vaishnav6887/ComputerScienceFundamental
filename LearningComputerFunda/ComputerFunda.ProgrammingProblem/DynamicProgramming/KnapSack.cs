using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.DynamicProgramming
{
    public class KnapSack
    {
        private List<int> _weights;
        private List<int> _profits;
        private int _capacity;
        public int _maxProfit { get; set; }
        public int _numberOfIteration { get; set; }
        private Dictionary<string, int> _memoization;

        public KnapSack(List<int> weights, List<int> profits, int capacity)
        {
            _capacity = capacity;
            _weights = weights;
            _profits = profits;
            _maxProfit = 0;
            _numberOfIteration = 0;
            _memoization = new Dictionary<string, int>();
        }

        public int Calculate(int remainingCapacity, int currentWeight = 0, int currentProfit = 0, int index = 0)
        {
            _numberOfIteration++;
            if (remainingCapacity <= 0 || index >= _weights.Count)
            {
                return currentProfit;
            }

            string key = $"{remainingCapacity}_{index}";
            if (_memoization.ContainsKey(key))
            {
                return _memoization[key];
            }
            

            int newWeight = currentWeight + _weights[index];

            int withCurrent = 0;
            int withOutCurrent = 0;
            
            if (newWeight <= _capacity)
                withCurrent = Calculate(remainingCapacity - _weights[index], newWeight, currentProfit + _profits[index], index + 1);

            withOutCurrent = Calculate(remainingCapacity, currentWeight, currentProfit, index + 1);

            _maxProfit = System.Math.Max(_maxProfit, System.Math.Max(withCurrent, withOutCurrent));
            _memoization.Add(key, System.Math.Max(withCurrent, withOutCurrent));
            return _memoization[key];
        }
    }
}
