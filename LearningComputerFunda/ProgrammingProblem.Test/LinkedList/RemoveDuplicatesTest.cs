using ComputerFunda.DataStructure.LinkedList;
using ComputerFunda.ProgrammingProblem.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.LinkedList
{
    [TestCategory("LinkedList")]
    [TestClass]
    public class RemoveDuplicatesTest
    {
        private RemoveDuplicate _data;

        private RemoveDuplicate _unsortedData;

        [TestInitialize]
        public void Init()
        {
            _data = new RemoveDuplicate(new DSNode<int>()
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
                                Data = 5,
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

            _unsortedData = new RemoveDuplicate(new DSNode<int>()
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
        public void Remove_Duplicate_Execute_Positive_Test()
        {
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
                                Data = 5,
                                Next = new DSNode<int>()
                                {
                                    Data = 6
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
        public void Remove_Duplicate_Unsorted_Using_Map_Test()
        {
            DSNode<int> expected = new DSNode<int>()
            {
                Data = 3,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 1,
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
            };

            DSNode<int> actual = _unsortedData.ExecuteUnSortedUsingMap();

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
        public void Remove_Duplicate_Unsorted_Test()
        {
            DSNode<int> expected = new DSNode<int>()
            {
                Data = 3,
                Next = new DSNode<int>()
                {
                    Data = 2,
                    Next = new DSNode<int>()
                    {
                        Data = 1,
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
            };

            DSNode<int> actual = _unsortedData.ExecuteUnSorted();

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
