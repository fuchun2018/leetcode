using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.TrapRainWater
{
    public class TrapRainWaterSolution
    {
        public int Trap(int[] height)
        {
            int result = 0;
            int left = 0, right = height.Length - 1;
            int leftPeak = left , rightPeak = right;
            while (left < right)
            {
                leftPeak = height[left] > height[leftPeak] ? left : leftPeak;
                rightPeak = height[right] > height[rightPeak] ? right : rightPeak;

                if (height[left] > height[right])
                {
                    result += Math.Max(0, height[rightPeak] - height[right]);
                    right--;
                }
                else
                {
                    result += Math.Max(0, height[leftPeak] - height[left]);
                    left++;
                }
            }
            return result;
        }
    }
}
