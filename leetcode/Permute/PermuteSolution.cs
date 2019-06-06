using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Permute
{
    public class PermuteSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<List<int>>();
            if (nums.Count() == 0) return result.Cast<IList<int>>().ToList();
            if (nums.Count() == 1)
            {
                result.Add(new List<int> { nums[0] });
                result.Cast<IList<int>>().ToList();
            }
            foreach (var item in nums)
            {
                var _ = new List<int>() { item };
                //_.AddRange();
                var t2 = Permute(nums.Where(t => t != item).ToArray());
            }
            return null;
        }
    }
}
