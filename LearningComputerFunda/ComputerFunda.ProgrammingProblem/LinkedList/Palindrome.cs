using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.DataStructure.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class Palindrome
    {
        private DSNode<char> _data;

        public Palindrome(DSNode<char> data)
        {
            _data = data;
        }

        public bool IsPalindrome()
        {
            if(_data == null) { return false; }

            FindMiddleOfList<char> findMiddle = new FindMiddleOfList<char>(_data);

            int middleIndex = findMiddle.findCenterIndex();

            DSStack<char> stack = new DSStack<char>();

            int index = 0;

            DSNode<char> current = _data;

            while(current != null)
            {
                if(index > middleIndex)
                {
                    var popped = stack.Pop();

                    if(popped != current.Data)
                    {
                        break;
                    }
                }
                else
                {
                    stack.Push(current.Data);
                    if (index == middleIndex && middleIndex % 2 != 0)
                    {
                        stack.Pop();
                    }
                }

                index++;
                
                current = current.Next;
            }

            return stack.Count == 0;
        }
    }
}
