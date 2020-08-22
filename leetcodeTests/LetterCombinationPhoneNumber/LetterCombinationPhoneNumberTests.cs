using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.LetterCombinationPhoneNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.LetterCombinationPhoneNumber
{
    [TestClass]
    public class LetterCombinationPhoneNumberTests
    {
        [TestMethod]
        public void Test()
        {
            LetterCombinationPhoneNumberSolution s = new LetterCombinationPhoneNumberSolution();
            var result = s.LetterCombinations("1234");
        }
    }
}
