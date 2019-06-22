namespace leetcode.FirstMissingPositive
{
    public class FirstMissingPositiveSolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 1;
            if (nums.Length == 1) return nums[0] == 1 ? 2 : 1;
            for (var cursor = 0; cursor < nums.Length; cursor++)
            {
                while (nums[cursor] - 1 >= 0 && nums[cursor] - 1 < nums.Length && nums[cursor] - 1 != cursor && nums[nums[cursor] - 1] != nums[cursor])
                {
                    var temp = nums[nums[cursor] - 1];
                    nums[nums[cursor] - 1] = nums[cursor];
                    nums[cursor] = temp;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] - 1 != i) return i + 1;
            }

            return nums.Length + 1;
        }
    }
}