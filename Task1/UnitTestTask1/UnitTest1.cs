
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace UnitTestTask1
{
	[TestClass]
	public class UnitTest1: Program
	{
        [TestMethod]
        [DataRow("abcdAAkl", 3)]
        [DataRow(" ", 1)]
        [DataRow("abccdfgh", 5)]
        public void TestOfNonRepeatUniquness(string entry, int result)
        {
            Assert.AreEqual(CountOfUniqueChar(entry), result);
        }


        [TestMethod]
        [DataRow("abcdAAkl", 3)]
        [DataRow(" ", 1)]
        [DataRow("abcdabcdefg", 11)]
        [DataRow("abcadefg", 8)]
        public void PositiveTestOfAbsoluteUniqueness(string entry, int result)
        {
            Assert.AreEqual(CountOfUniqueChar(entry), result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow("")]
        public void NegativeTestOfAbsoluteUniqueness(string entry)
        {
            int result = CountOfUniqueChar(entry);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow("")]
        public void NegativeTestOfNonRepeatUniquness(string entry)
        {
            int result = CountOfUniqueChar(entry);
        }
    }
}
