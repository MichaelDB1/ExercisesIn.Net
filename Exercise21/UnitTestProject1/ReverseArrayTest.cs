using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise21;





namespace Exercise21Test
{
    [TestClass]
    public class ReverseArrayTest
    {
        /*
        int[] TheResults;


        public void GetArray(int[] arrays)
        {      
            TheResults = arrays;
        }

        public string CheckReversed()
        {
            string result = string.Join(",", TheResults);
            return result;
        }
        */
        [TestMethod]
        public void TestReverseArray()
        {
            int[] Expected = new int[5] { 26, 79, 34, 56, 12 };                                                   
            CollectionAssert.AreEqual(Expected, TheResults, "Array Reversed properly");
        }

    }
}
