using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ThreeSum
{
    public class ThreeSumClosetSolution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var offset = int.MaxValue;
            var max = int.MinValue;
            if (nums.Length < 2) return -1;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if(i>0 && nums[i] == nums[i-1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    var internalOffset = 0;
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == target) return target;
                    internalOffset = Math.Abs(sum - target);
                    if (sum > target) right--;
                    if (sum < target) left++;
                    if (internalOffset < offset)
                    {
                        offset = internalOffset;
                        max = sum;
                    }
                }
            }
            return max;
        }
    }
}
