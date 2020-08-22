using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.ThreeSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.ThreeSum
{
    [TestClass]
    public class ThreeSumClosetTests
    {
        [TestMethod]
        public void Test()
        {
            ThreeSumClosetSolution s = new ThreeSumClosetSolution();
            var res = s.ThreeSumClosest(new[] {-1, 2, 1, -4}, 1);

        }
    }
}
