using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.ProgrammingProblem.LinkedList;
using ComputerFunda.DataStructure.LinkedList;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("LinkedList")]
    [TestClass]
    public class RemoveListElementTest
    {
        private RemoveListElement _data;

        [TestInitialize]
        public void Init()
        {
            var head = new DSNode<int>();
            head.Data = 1;
            head.Next = new DSNode<int>()
            {
                Data = 2,
                Next = new DSNode<int>()
                {
                    Data = 3,
                    Next = new DSNode<int>()
                    {
                        Data = 4,
                        Next = new DSNode<int>()
                        {
                            Data = 6,
                            Next = new DSNode<int>()
                            {
                                Data = 7,
                                Next = new DSNode<int>()
                                {
                                    Data = 5,
                                    Next = new DSNode<int>()
                                    {
                                        Data = 6
                                    }
                                }
                            }
                        }
                    }
                }
            };

            _data = new RemoveListElement(head); 
        }

        [TestMethod]
        public void Execute_Positive_Test()
        {
            int input = 6;

            DSNode<int> actual = _data.Execute(input);

            DSNode<int> expected = new DSNode<int>()
            {
                Data = 1,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 3,
                        Next = new DSNode<int>()
                        {
                            Data = 4,
                            Next = new DSNode<int>()
                            {
                                Data = 7,
                                Next = new DSNode<int>()
                                {
                                    Data = 5
                                }
                            }
                        }
                    }
                }
            };

            while(expected != null && actual != null)
            {
                Assert.AreEqual(expected.Data, actual.Data);

                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.IsNull(expected);
            Assert.IsNull(actual);
        }
    }
}
