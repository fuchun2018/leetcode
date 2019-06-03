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
            SortedList<int, int> list = new SortedList<int, int>();
                
            foreach (var item in nums)
            {
                if (list.ContainsKey(item)) list[item]++;
                else list.Add(item, 1);
            }
            return list.OrderByDescending(t => t.Value).First().Key;
        }
    }
}
