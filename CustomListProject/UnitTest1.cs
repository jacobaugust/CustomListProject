using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSingleVariableIndex_CheckIndex0_OneIntPlacedAtIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 8;
            myList.Add(value);
            Assert.AreEqual(value, myList[0]);

        }
        public void AddTwoVariablesIndex_CheckIndex0And1_EachIntPlacedAtProperIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 8;
            int value2 = 16;
            myList.Add(value);
            myList.Add(value2);
            Assert.AreEqual(value2, myList[1]);

        }
        public void AddThreeVariablesIndex_CheckIndex0And1And2_EachIntPlacedAtProperIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            Assert.AreEqual(value3, myList[2]);

        }
        public void AddThreeVariablesIndex_CheckIndex0And1And2And3_EachIntPlacedAtProperIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            int value4 = 64;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            Assert.AreEqual(value4, myList[3]);
        }
        public void AddThreeVariablesIndex_CheckIndex0And1And2And3And4_EachIntPlacedAtProperIndex()
        {
            CustomList<int> myList = new CustomList<int>();
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
            Assert.AreEqual(value5, myList[4]);
        }
        public void AddFifteenVariablesIndex_CheckIndex0Value_IntPlacedAtProperIndex()
        {
            CustomList<int> myList = new CustomList<int>();
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
            Assert.AreEqual(value, myList[0]);
        }
        public void AddFifteenVariablesIndex_CheckCount_CountAtReturnsNumberOfListedInts()
        {
            CustomList<int> myList = new CustomList<int>();
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
            Assert.AreEqual(15, CustomList.Count);
        }
    }
}
