using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.MoveZeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MoveZeroes.Tests
{
    [TestClass()]
    public class MoveZeroesSolutionTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            var solution = new MoveZeroesSolution();
             solution.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        }

        [TestMethod()]
        public void MoveZeroesTest_Case_2()
        {
            var solution = new MoveZeroesSolution();
            solution.MoveZeroes(new int[] { 1, 0, 0, 2, 0, 1, 0, 133,381,33,13 });
        }
    }
}