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
            var list = new SortedSet<int>();
            foreach (var item in height)
            {
                if ((list.Contains(item) == false) && (item > 0))
                    list.Add(item);
            }
            int result = 0;
            int low = 0, high = height.Length - 1;
            int peak = 0;
            while (low < high)
            {
                var item = list.First();
                var diff = item - peak;
                peak = item;
                while ((height[low] < peak) && low < high) low++;
                while ((height[high] < peak) && high > 0) high--;
                for (int i = low; i < high; i++)
                    if (height[i] < peak) result += diff;
                list.Remove(peak);
                if (list.Count() == 0) break;
            }
            return result;
        }
    }
}
