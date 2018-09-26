using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TheSolution;

namespace UnitTests
{
    [TestClass]
    public class QuestionOneTest
    {
        private QuestionOne questionOne;
        [TestInitialize]
        public void Setup()
        {
            questionOne = new QuestionOne(new double[] { 1,2,3,4,5,6,7});
        }
        [TestMethod]
        public void TestGetMean()
        {
            var expected = 4;
            var actual=questionOne.GetMean();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetMedian()
        {
            var expected = 4;
            var actual = questionOne.GetMedian();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetMode()
        {
            var expected = "none";
            var actual = questionOne.GetMode();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetRange()
        {
            var expected = 6;
            var actual = questionOne.GetRange();
            Assert.AreEqual(expected, actual);
        }
    }
}
