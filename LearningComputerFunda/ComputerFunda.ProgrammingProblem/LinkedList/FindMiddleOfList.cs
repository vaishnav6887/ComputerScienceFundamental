using ComputerFunda.DataStructure.LinkedList;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class FindMiddleOfList<T>
    {
        private DSNode<T> _data;

        public FindMiddleOfList(DSNode<T> data)
        {
            _data = data;
        }

        public int findCenterIndex()
        {
            if (_data == null) { return -1; }

            DSNode<T> current = _data;

            DSNode<T> runner = _data;

            int index = 0;

            while (runner != null && runner.Next != null)
            {
                current = current.Next;
                runner = runner.Next.Next;
                index++;
            }

            if(index % 2 == 0)
            {
                index = index - 1;
            }

            return index;
        }
    }
}
