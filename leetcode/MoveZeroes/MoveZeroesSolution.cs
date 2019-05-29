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
                    for (int j = i; j > leadPosition; j--)
                    {
                        var temp = nums[j];
                        nums[j] = nums[j-1];
                        nums[j - 1] = temp;
                    }
                    leadPosition++;
                }
            }
        }
    }
}
