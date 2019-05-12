using ComputerFunda.DataStructure.LinkedList;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class DeleteMiddleElementInList
    {
        private DSNode<int> _head;

        public DeleteMiddleElementInList(DSNode<int> head)
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
            while(runner != null && runner.Next != null)
            {
                runner = runner.Next.Next;
                if(runner != null && runner.Next != null)
                {
                    current = current.Next;
                }
            }

            current.Next = current.Next.Next;

            return _head;
        }

        public DSNode<int> ExecuteWithAccessToMiddleNode(DSNode<int> middle)
        {
            if(middle == null || middle.Next == null) { return null; }

            middle.Data = middle.Next.Data;
            middle.Next = middle.Next.Next;

            return middle;
        }
    }
}
