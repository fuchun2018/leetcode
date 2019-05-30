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
            int low = 0, high = height.Length - 1;
            int peak = 1;
            while(low < high)
            {
                while (height[low] != peak) low++;
                while (height[high] != peak) high--;
                for (int i = low; i < high; i++)
                    if (height[i] <= peak - 1) result++;
                peak++;
            }
            return result;
        }
    }
}
