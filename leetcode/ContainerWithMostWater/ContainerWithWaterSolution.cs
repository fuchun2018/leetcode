using System;

namespace leetcode.ContainerWithMostWater
{
    public class ContainerWithWaterSolution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            if (height.Length <= 1) return maxArea;

            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }
            return maxArea;
        }
    }
}