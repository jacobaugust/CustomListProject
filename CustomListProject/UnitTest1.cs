using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSingleVariableIndex_CheckIndex0_OneIntPlacedAtIndex0()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            myList.Add(value);
            Assert.AreEqual(value, myList[0]);

        }
        [TestMethod]
        public void AddTwoVariablesIndex_CheckIndex0And1_EachIntPlacedAtProperIndex()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            myList.Add(value);
            myList.Add(value2);
            Assert.AreEqual(value2, myList[1]);

        }
        [TestMethod]
        public void AddThreeVariablesIndex_CheckIndex0And1And2_EachIntPlacedAtProperIndex()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 8;
            int value2 = 16;
            int value3 = 32;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            Assert.AreEqual(value3, myList[2]);

        }
        [TestMethod]
        public void AddThreeVariablesIndex_CheckIndex0And1And2And3_EachIntPlacedAtProperIndex()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
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
        [TestMethod]
        public void AddThreeVariablesIndex_CheckIndex0And1And2And3And4_EachIntPlacedAtProperIndex()
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
            Assert.AreEqual(value5, myList[4]);
        }
        [TestMethod]
        public void AddFifteenVariablesIndex_CheckIndex0Value_IntPlacedAtProperIndex()
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
            Assert.AreEqual(value8, myList[7]);
        }
        [TestMethod]
        public void AddFifteenVariablesIndex_CheckCount_CountAtReturnsNumberOfListedInts()
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
            Assert.AreEqual(15, myList.count);
        }
        [TestMethod]
        public void OverloadAddOperator_CheckCombinedLists_NewListHasElementsFromFirstList()
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
            CustomListClass<int> myList2 = new CustomListClass<int>();
            int num = 8;
            int num2 = 16;
            int num3 = 32;
            int num4 = 64;
            int num5 = 128;
            myList2.Add(num);
            myList2.Add(num2);
            myList2.Add(num3);
            myList2.Add(num4);
            myList2.Add(num5);
            CustomListClass<int> combinedList = new CustomListClass<int>();
            combinedList = myList + myList2;
            Assert.AreEqual(value5, combinedList[4]);
        }
        [TestMethod]
        public void OverloadAddOperator_CheckCombinedLists_NewListHasElementsFromSecondList()
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
            CustomListClass<int> myList2 = new CustomListClass<int>();
            int num = 8;
            int num2 = 16;
            int num3 = 32;
            int num4 = 64;
            int num5 = 128;
            myList2.Add(num);
            myList2.Add(num2);
            myList2.Add(num3);
            myList2.Add(num4);
            myList2.Add(num5);
            CustomListClass<int> combinedList = new CustomListClass<int>();
            combinedList = myList + myList2;
            Assert.AreEqual(num5, combinedList[9]);
        }
        [TestMethod]
        public void ZippedLists_CheckZippedLists_NewListHasSecondListElementsInProperOrder()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 1;
            int value2 = 3;
            int value3 = 5;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            CustomListClass<int> myList2 = new CustomListClass<int>();
            int num = 2;
            int num2 = 4;
            int num3 = 6;
            myList2.Add(num);
            myList2.Add(num2);
            myList2.Add(num3);
            CustomListClass<int> zippedList = new CustomListClass<int>();
            zippedList = myList + myList2;
            myList.ZipList(myList, myList2, zippedList);
            Assert.AreEqual(num, zippedList[1]);
        }
        [TestMethod]
        public void ZippedLists_CheckZippedLists_NewListHasFirstListElementsInProperOrder()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 1;
            int value2 = 3;
            int value3 = 5;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            CustomListClass<int> myList2 = new CustomListClass<int>();
            int num = 2;
            int num2 = 4;
            int num3 = 6;
            myList2.Add(num);
            myList2.Add(num2);
            myList2.Add(num3);
            CustomListClass<int> zippedList = new CustomListClass<int>();
            myList.ZipList(myList, myList2, zippedList);
            Assert.AreEqual(value3, zippedList[4]);
        }
        [TestMethod]
        public void ZippedLists_CheckZippedLists_NewListHasLastElementInProperOrder()
        {
            CustomListClass<int> myList = new CustomListClass<int>();
            int value = 1;
            int value2 = 3;
            int value3 = 5;
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            CustomListClass<int> myList2 = new CustomListClass<int>();
            int num = 2;
            int num2 = 4;
            int num3 = 6;
            myList2.Add(num);
            myList2.Add(num2);
            myList2.Add(num3);
            CustomListClass<int> zippedList = new CustomListClass<int>();
            myList.ZipList(myList, myList2, zippedList);
            Assert.AreEqual(num3, zippedList[5]);
        }
    }
}
