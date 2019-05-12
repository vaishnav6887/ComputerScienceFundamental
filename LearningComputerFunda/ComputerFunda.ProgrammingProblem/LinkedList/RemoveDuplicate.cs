using ComputerFunda.DataStructure.LinkedList;
using System.Collections.Generic;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class RemoveDuplicate
    {
        private DSNode<int> _head;
        public RemoveDuplicate(DSNode<int> head)
        {
            _head = head;
        }

        public DSNode<int> Execute()
        {
            if(_head == null)
            {
                return null;
            }

            DSNode<int> current = _head;
            DSNode<int> runner = _head.Next;

            while(runner != null)
            {
                if(runner.Data == current.Data)
                {
                    runner = runner.Next;
                    current.Next = runner;
                }
                else
                {
                    current = runner;
                    runner = runner.Next;
                }
            }

            return _head;
        }

        public DSNode<int> ExecuteUnSortedUsingMap()
        {
            if(_head == null)
            {
                return null;
            }

            Dictionary<int, bool> map = new Dictionary<int, bool>();

            DSNode<int> current = _head;
            DSNode<int> runner = _head.Next;

            map.Add(current.Data, true);

            while (runner != null)
            {
                if (map.ContainsKey(runner.Data))
                {
                    runner = runner.Next;
                    current.Next = runner;
                }
                else
                {
                    map.Add(runner.Data, true);
                    current = runner;
                    runner = runner.Next;
                }
            }

            return _head;
        }

        public DSNode<int> ExecuteUnSorted()
        {
            if(_head == null)
            {
                return null;
            }

            DSNode<int> current = _head;
            
            while(current != null)
            {
                DSNode<int> r1 = current;
                DSNode<int> runner = r1.Next;

                while (runner != null)
                {
                    if (current.Data == runner.Data)
                    {
                        r1.Next = runner.Next;
                    }

                    r1 = runner;
                    runner = runner.Next;
                }

                current = current.Next;
            }

            return _head;
        }
    }
}
