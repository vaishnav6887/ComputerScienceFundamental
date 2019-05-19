using ComputerFunda.DataStructure.ArrayList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerFunda.DataStructure.Test.ArrayList
{
    [TestCategory("ArrayList")]
    [TestClass]
    public class DSArrayTest
    {
        [TestMethod]
        public void ReverseRotate_Test()
        {
            var dsArray = new DSArray<int>(10);

            dsArray._data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            dsArray.ReverseRotate(2);

            Assert.IsTrue(dsArray._data[dsArray.Count - 1] == 2);

            Assert.IsTrue(dsArray._data[0] == 3);
        }

        [TestMethod]
        public void FindFrequency_Of_All_Element()
        {
            var dsArray = new DSArray<int>(10);

            dsArray._data = new int[] { 1, 2, 2, 2, 2, 6, 7, 8, 8, 1 };

            var returnValue = dsArray.FindFrequencyOfElement();

            Assert.AreEqual(2, returnValue[1]);
            Assert.AreEqual(4, returnValue[2]);
            Assert.AreEqual(1, returnValue[6]);
            Assert.AreEqual(1, returnValue[7]);
            Assert.AreEqual(2, returnValue[8]);
            Assert.IsFalse(returnValue.ContainsKey(9));
        }

        [TestMethod]
        public void FCountFrequency_Of_All_Element()
        {
            var dsArray = new int[10] { 1, 2, 2, 2, 2, 6, 7, 8, 8, 1 };

            var dsArr = new DSArray<int>(10) { _data = dsArray };
            var returnValue = dsArr.FindFrequencyOfElement();

            Assert.AreEqual(2, returnValue[1]);
            Assert.AreEqual(4, returnValue[2]);
            Assert.AreEqual(1, returnValue[6]);
            Assert.AreEqual(1, returnValue[7]);
            Assert.AreEqual(2, returnValue[8]);
            Assert.IsFalse(returnValue.ContainsKey(9));
        }
    }
}
