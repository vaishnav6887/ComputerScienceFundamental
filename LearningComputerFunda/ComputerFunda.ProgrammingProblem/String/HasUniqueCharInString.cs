using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.String
{
    public static class HasUniqueCharInString
    {
        public static bool HasUnique(string input)
        {
            Dictionary<char, bool> map = new Dictionary<char, bool>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input.ElementAt(i);
                if (map.ContainsKey(currentChar))
                {
                    return false;
                }

                map.Add(currentChar, true);
            }

            return true;
        }

        public static bool HasUniqueWithOutExtraSpace(string input)
        {
            bool[] map = new bool[128];

            for(int i = 0; i < input.Length; i++)
            {
                int currentChar = (int)input.ElementAt(i);

                if(map[currentChar])
                {
                    return false;
                }

                map[currentChar] = true;
            }

            return true;
        }
    }
}
