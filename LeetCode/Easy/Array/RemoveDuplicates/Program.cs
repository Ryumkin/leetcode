public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }
        var index = 1;
        var count = 1;
        var previousNumber = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (previousNumber == nums[i])
            {
                continue;
            }
            count++;
            nums[index++] = previousNumber = nums[i];
        }

        return count;
    }
}