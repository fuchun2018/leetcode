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
    }
}