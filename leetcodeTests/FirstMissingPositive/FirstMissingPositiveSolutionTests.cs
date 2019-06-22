using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.FirstMissingPositive.Tests
{
    [TestClass()]
    public class FirstMissingPositiveSolutionTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 1, 2, 0 };
            var expect = 3;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest_Case_2()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 3, 4, -1, 1 };
            var expect = 2;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest_Case_3()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 7, 8, 9, 11, 12 };
            var expect = 1;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest_Case_4()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] {  };
            var expect = 1;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest_Case_5()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 1, 1};
            var expect = 2;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void FirstMissingPositiveTest_Case_6()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 2, 1 };
            var expect = 3;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }
    }
}