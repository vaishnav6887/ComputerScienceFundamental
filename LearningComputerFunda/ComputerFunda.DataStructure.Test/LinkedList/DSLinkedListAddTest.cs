using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFunda.DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerFunda.Common;

namespace ComputerFunda.DataStructure.Test.LinkedList
{
    [TestClass]
    public class DSLinkedListAddTest
    {
        [TestMethod]
        public void Add_Test_Positive_CountCheck()
        {
            DSLinkedList<int> actual = new DSLinkedList<int>();

            actual.Add(5);
            actual.Add(10);
            actual.Add(15);
            actual.Add(20);

            Assert.AreEqual(4, actual.Count);
        }

        [TestMethod]
        public void Add_Test_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt4thIndex = lnkLst.ValueAtIndex(4);

            Assert.AreEqual(15, actual2ndIndex);

            Assert.AreEqual(25, actualAt4thIndex);
        }

        [TestMethod]
        public void Add_Test_Delete_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            IntDSNodeEqualityComparer intDSNodeEqualityComparer = new IntDSNodeEqualityComparer();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);
            lnkLst.Delete(10, intDSNodeEqualityComparer);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt3rdIndex = lnkLst.ValueAtIndex(3);

            Assert.AreEqual(20, actual2ndIndex);

            Assert.AreEqual(25, actualAt3rdIndex);
        }

        [TestMethod]
        public void Add_Test_Delete_BY_INDEX_Positive_Data_Validation()
        {
            DSLinkedList<int> lnkLst = new DSLinkedList<int>();

            lnkLst.Add(5);
            lnkLst.Add(10);
            lnkLst.Add(15);
            lnkLst.Add(20);
            lnkLst.Delete(1);

            int actual2ndIndex = lnkLst.ValueAtIndex(2);

            lnkLst.Add(25);

            int actualAt3rdIndex = lnkLst.ValueAtIndex(3);

            Assert.AreEqual(20, actual2ndIndex);

            Assert.AreEqual(25, actualAt3rdIndex);
        }
    }
}
