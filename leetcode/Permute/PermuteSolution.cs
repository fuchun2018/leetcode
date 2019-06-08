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
                return  result.Cast<IList<int>>().ToList();
            }
            Util(new List<int>(), nums.ToList(), result);
            return result.Cast<IList<int>>().ToList();
        }

        private void Util(List<int> current, List<int> wip, List<List<int>> result)
        {
            if (wip.Count == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            foreach (var item in wip)
            {
                current.Add(item);
                Util(current, wip.Where(t => t != item).ToList(), result);
                current.Remove(item);
            }
        }
    }
}
