using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.HashMap
{
    public class WordFrequency
    {
        private string[] Book { get; }

        private Dictionary<string, int> _map;

        public WordFrequency(string[] book)
        {
            Book = book;

            _map = new Dictionary<string, int>();
        }

        public int FindWordFrequency(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException("Word to be searched can not be null or empty.");
            }

            if (_map.ContainsKey(word))
            {
                return _map[word];
            }
            else
            {
                int frequency = 0;

                frequency = Book.Count(s => s.Contains(word));

                _map.Add(word, frequency);

                return frequency;
            }
        }
    }
}
