public sealed class RemoveDuplicatesSolution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }
        var index = 1;
        var previousNumber = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (previousNumber == nums[i])
            {
                continue;
            }
            nums[index++] = previousNumber = nums[i];
        }

        return index;
    }
}