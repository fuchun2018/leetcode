﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.DivideTwoIntegers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DivideTwoIntegers.Tests
{
    [TestClass()]
    public class DivideSolutionTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            var solution = new DivideSolution();

            var result = solution.Divide(100, 3);
            Assert.AreEqual(result, 33);
        }

        [TestMethod()]
        public void DivideTest_Case_2()
        {
            var solution = new DivideSolution();

            var result = solution.Divide(7, -3);
            Assert.AreEqual(result, -2);
        }

        [TestMethod()]
        public void DivideTest_Case_3()
        {
            var solution = new DivideSolution();

            var result = solution.Divide(-10, -3);
            Assert.AreEqual(result, 3);
        }
    }
}