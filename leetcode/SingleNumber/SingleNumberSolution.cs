using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.SingleNumber
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length < 2) return nums[0];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+=2)
            {
                if (i + 1 != nums.Length)
                {
                    if  (nums[i] != nums[i + 1])
                        return nums[i];
                }
                else
                    if (nums[i] != nums[i - 1]) return nums[i];
            }
            return 0;
        }
    }
}
