using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TheSolution;

namespace UnitTests
{
    [TestClass]
    public class QuestionTwoTest
    {
        private QuestionTwo questionTwo;
        [TestInitialize]
        public void Setup()
        {
            questionTwo = new QuestionTwo("thisis a samplestring");
        }
        [TestMethod]
        public void TestGetCount()
        {
            IDictionary<char,int> expected = new SortedDictionary<char, int>()
            {
                ['a'] = 2,
                ['e'] = 1,
                ['g'] = 1,
                ['h'] = 1,
                ['i'] = 3,
                ['l'] = 1,
                ['m'] = 1,
                ['n'] = 1,
                ['p'] = 1,
                ['r'] = 1,
                ['s'] = 4,
                ['t'] = 2
            };
            var actual = questionTwo.GetCount();
            CollectionAssert.AreEquivalent((ICollection)expected, (ICollection)actual);
        }
    }
}
