using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ThreeSum
{
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();
            if (nums.Length < 3) return result.Cast<IList<int>>().ToList();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    var _ = nums[i] + nums[left] + nums[right];
                    if(_ == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        do { left++; } while (left < nums.Length - 1 && nums[left + 1] == nums[left]);
                        do { right--; } while (right > 0 &&  nums[right - 1] == nums[right]);
                    }
                    else
                    {
                        if (_ > nums[left]) left++;
                        else right--;
                    }
                }
            }
            return result.Cast<IList<int>>().ToList();
        }
    }
}
