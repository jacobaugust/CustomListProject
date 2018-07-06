using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace CustomListProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void RemoveSpecificSingleVariable_CheckIndexNumbers_IndexOfExistingVariablesUpdatedAfterRemove()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value3);
            Assert.AreEqual(value4, myList[2]);
        }
        [TestMethod]
        public void RemoveSpecificSingleVariable_CheckLaterIndexNumbers_IndexOfExistingVariablesUpdatedAfterRemove()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value3);
            Assert.AreEqual(value5, myList[3]);
        }
        [TestMethod]
        public void RemoveSpecificSingleVariable_CheckCountOfArray_ArrayCountUpdatedAfterRemove()

        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            int value6 = 8;
            int value7 = 16;
            int value8 = 32;
            int value9 = 64;
            int value10 = 128;
            int value11 = 8;
            int value12 = 16;
            int value13 = 32;
            int value14 = 64;
            int value15 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);
            myList.Add(value10);
            myList.Add(value11);
            myList.Add(value12);
            myList.Add(value13);
            myList.Add(value14);
            myList.Add(value15);
            myList.Remove(value15);
            Assert.AreEqual(14, myList.count);
        }

            [TestMethod]
            public void RemoveSpecificSingleVariableUnsuccessfully_CheckCountOfArray_ArrayCountNotChangedByFailedRemoval()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            int value6 = 8;
            int value7 = 16;
            int value8 = 32;
            int value9 = 64;
            int value10 = 128;
            int value11 = 8;
            int value12 = 16;
            int value13 = 32;
            int value14 = 64;
            int value15 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);
            myList.Add(value10);
            myList.Add(value11);
            myList.Add(value12);
            myList.Add(value13);
            myList.Add(value14);
            myList.Add(value15);
            myList.Remove(55);
            Assert.AreEqual(15, myList.count);

        }
        [TestMethod]
        public void RemoveSpecificSingleVariableUnsuccessfully_CheckItemValue_ExistingVariablesUnChangedAfterFailedRemoval()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(100);
            Assert.AreEqual(value5, myList[4]);
        }
        [TestMethod]
        public void ChangeValuesToString_CheckStringDesignation_LongListAlteredToString()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.ToString();
            Assert.AreEqual("8163264128", myList.ToString());
        }
        [TestMethod]
        public void ChangeValuesToString_CheckStringDesignation_LongerListAlteredToString()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            int value5 = 128;
            int value6 = 88;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.ToString();
            Assert.AreEqual("816326412888", myList.ToString());
        }
        





    }
}
