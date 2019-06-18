namespace leetcode.FirstMissingPositive
{
    public class FirstMissingPositiveSolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 1;
            if (nums.Length == 1) return nums[0] == 1 ? 2 : 1;
            for (int cursor = 0; cursor < nums.Length; cursor++)
            {
                while (nums[cursor] > 0 && nums[cursor] < nums.Length && nums[cursor] != cursor)
                {
                    var temp = nums[nums[cursor]];
                    nums[nums[cursor]] = nums[cursor];
                    nums[cursor] = temp;
                }
            }

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != i) return i;
            }

            return nums.Length;
        }
    }
}