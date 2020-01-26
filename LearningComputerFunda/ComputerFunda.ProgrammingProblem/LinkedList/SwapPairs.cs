using ComputerFunda.DataStructure.LinkedList;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class SwapPairs
    {
        private DSNode<int> _head;

        public SwapPairs(DSNode<int> head)
        {
            _head = head;
        }

        public DSNode<int> Swap()
        {
            if (_head == null)
                return null;

            if (_head.Next == null)
                return _head;

            var current = _head;
            DSNode<int> prev = null;
            var next = _head.Next;
            DSNode<int> newHead = null;

            while (current != null && next != null)
            {
                DSNode<int> cached = this.SwapHelper(current, next, ref prev, ref newHead);

                current = cached;

                if (current != null)
                    next = current.Next;
            }

            return newHead;
        }

        private DSNode<int> SwapHelper(DSNode<int> current, DSNode<int> next, ref DSNode<int> prev, ref DSNode<int> newHead)
        {
            var cached = next.Next;
            next.Next = current;
            current.Next = cached;

            if (prev != null)
                prev.Next = next;

            prev = current;

            if (newHead == null)
                newHead = next;

            return cached;
        }
    }
}
