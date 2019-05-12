using System;
using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.ProgrammingProblem.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("LinkedList")]
    [TestClass]
    public class DeleteMiddleElementInListTest
    {
        private DeleteMiddleElementInList _data;

        [TestInitialize]
        public void Init()
        {
            _data = new DeleteMiddleElementInList(new DSNode<int>()
            {
                Data = 3,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 3,
                        Next = new DSNode<int>()
                        {
                            Data = 1,
                            Next = new DSNode<int>()
                            {
                                Data = 2,
                                Next = new DSNode<int>()
                                {
                                    Data = 5,
                                    Next = new DSNode<int>()
                                    {
                                        Data = 6,
                                        Next = new DSNode<int>()
                                        {
                                            Data = 6
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
        }

        [TestMethod]
        public void DeleteMiddleElement_Positive()
        {
            DSNode<int> expected = new DSNode<int>()
            {
                Data = 3,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 3,
                        Next = new DSNode<int>()
                        {
                            Data = 2,
                            Next = new DSNode<int>()
                            {
                                Data = 5,
                                Next = new DSNode<int>()
                                {
                                    Data = 6,
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

            DSNode<int> actual = _data.Execute();

            while (expected != null && actual != null)
            {
                Assert.AreEqual(expected.Data, actual.Data);

                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.IsNull(expected);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DeleteMiddleElement_WithAccessToMiddleElement_Positive()
        {
            DSNode<int> expected = new DSNode<int>()
            {
                Data = 2,
                Next = new DSNode<int>()
                {
                    Data = 5,
                    Next = new DSNode<int>()
                    {
                        Data = 6,
                        Next = new DSNode<int>()
                        {
                            Data = 6
                        }
                    }
                }
            };

            DSNode<int> input = new DSNode<int>()
            {
                Data = 1,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 5,
                        Next = new DSNode<int>()
                        {
                            Data = 6,
                            Next = new DSNode<int>()
                            {
                                Data = 6
                            }
                        }
                    }
                }
            };

            DSNode<int> actual = _data.ExecuteWithAccessToMiddleNode(input);

            while (expected != null && actual != null)
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
