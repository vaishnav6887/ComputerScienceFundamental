using System.Collections.Generic;
using System.Linq;

namespace ComputerFunda.ProgrammingProblem.HashMap
{
    /// <summary>
    /// At a popular bar, each customer has a set of favorite drinks, and will happily accept any drink among this set. 
    /// For example, in the folllowing situation, customer 0 will be satified with drinks 0, 1, 3, or 6.
    /// Preferences: {
    /// 0: [0, 1, 3, 6],
    /// 1: [1,4,7],
    /// 2: [2,4,7,5],
    /// 3: [3,2,5],
    /// 4: [5,8]
    /// 
    /// Lazy bar tender is trying to reduce his efforts by limiting the drinkshe must learn in order to satisfy all customers.
    /// For the input above, the answer would be 2, as drinks 1 and 5 will satisfy everyone.
    /// </summary>
    public class TopFavoriteDrinks
    {
        private int[] FindFavoriteDrinks(Dictionary<int, int[]> customerPrefrences)
        {
            List<int> returnValue = new List<int>();

            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();

            HashSet<int> uniqueCust = new HashSet<int>();

            foreach(var data in customerPrefrences)
            {
                foreach(var pref in data.Value)
                {
                    if (map.ContainsKey(pref))
                    {
                        map[pref].Add(data.Key);
                    }
                    else
                    {
                        map[pref] = new HashSet<int>() { data.Key };
                    }

                    uniqueCust.Add(data.Key);
                }
            }

            var items = map.OrderByDescending(s => s.Value.Count);
            int i = 0;
            while (items.Count() > i)
            {
                var current = items.ElementAt(i);

                bool isRequired = false;

                foreach (var item in current.Value)
                {
                    if (uniqueCust.Contains(item))
                    {
                        isRequired = true;
                        break;
                    }
                }

                uniqueCust.RemoveWhere(s => current.Value.Contains(s));

                if (isRequired)
                {
                    returnValue.Add(current.Key);
                }

                i++;
            }

            return returnValue.ToArray();
        }

        public int CountOfFavoriteDrinks(Dictionary<int, int[]> customerPrefrences)
        {
            return FindFavoriteDrinks(customerPrefrences).Length;
        }
    }
}
