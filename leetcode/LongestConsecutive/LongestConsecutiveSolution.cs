using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LongestConsecutive
{
    public class LongestConsecutiveSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 2) return nums.Count();
            var hashSet = new HashSet<int>(nums);

            int result= 0;

            foreach (var item in nums)
            {
                var count = 0;
                var iterate = item;
                while (hashSet.Contains(iterate++))
                {
                    count++;
                }
                result = count > result ? count : result;
            }
            return result;
        }
    }
}
