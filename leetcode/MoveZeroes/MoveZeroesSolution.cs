using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MoveZeroes
{
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            int leadPosition = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[leadPosition++] = nums[i];
                }
            }
            while (leadPosition < nums.Length) nums[leadPosition++] = 0;
        }
    }
}
