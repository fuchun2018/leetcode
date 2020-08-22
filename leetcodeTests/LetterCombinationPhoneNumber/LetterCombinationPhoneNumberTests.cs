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

        [TestMethod]
        public void Test2()
        {
            LetterCombinationPhoneNumberSolution s = new LetterCombinationPhoneNumberSolution();
            var result = s.FindKthPositive(new[] { 2, 3, 4, 7, 11 }, 5);
        }

        [TestMethod]
        public void Test3()
        {
            LetterCombinationPhoneNumberSolution s = new LetterCombinationPhoneNumberSolution();
            var result = s.RestoreString("codeleet", new[] {4, 5, 6, 7, 0, 2, 1, 3});
        }
    }
}
