using leetcode.ContainerWithMostWater;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.ContainerWithMostWater
{
    [TestClass]
    public class ContainerWithWaterTests
    {
        [TestMethod]
        public void Test()
        {
            var container = new ContainerWithWaterSolution();
            var area = container.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Assert.AreEqual(49, area);
        }
    }
}