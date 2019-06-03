using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MajorityElement
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            return nums.GroupBy(t => t).Where(u => u.Count() > nums.Length / 2).OrderByDescending(v => v.Count()).FirstOrDefault().Key;
        }
    }
}
