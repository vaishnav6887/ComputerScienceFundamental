using ComputerFunda.DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class RemoveListElement
    {
        private DSNode<int> _head;
        public RemoveListElement(DSNode<int> head)
        {
            _head = head;
        }

        public DSNode<int> Execute(int val)
        {
            if(_head == null)
            {
                return _head;
            }

            DSNode<int> current = _head;
            DSNode<int> runner = _head.Next;

            while(runner != null)
            {
                if(runner.Data == val)
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

            if(_head.Data == val)
            {
                return _head.Next;
            }

            return _head;
        }
    }
}
