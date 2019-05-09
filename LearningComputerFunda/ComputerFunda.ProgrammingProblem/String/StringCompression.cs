using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.String
{
    public class StringCompression
    {
        public string Compress(string input)
        {
            if(input == null)
            {
                throw new ArgumentException("Input string can not be null");
            }

            StringBuilder returnValue = new StringBuilder();
            int count = 0;
            char currentChar = input.ElementAt(0);
            string activeString = "";

            for (int i = 0; i < input.Length; i++)
            {
                
                if(returnValue.Length > input.Length)
                {
                    return input;
                }

                char current = input.ElementAt(i);

                if(current == currentChar)
                {
                    StringBuilder str = new StringBuilder();
                    count++;
                    activeString = str.AppendFormat("{0}{1}", currentChar, count).ToString();
                }
                else
                {
                    returnValue = returnValue.AppendFormat("{0}{1}", currentChar, count);
                    count = 1;
                }

                currentChar = current;
            }

            if (activeString.Length > 0)
            {
                returnValue = returnValue.Append(activeString);
            }

            return returnValue.Length <= input.Length ? returnValue.ToString() : input;
        }
    }
}
