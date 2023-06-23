public class TwiSumSln {
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var value = target - nums[i];
            if (dictionary.TryGetValue(nums[i], out var index))
            {
                return new[] { index, i };
            }

            dictionary[value] = i;
        }

        return Array.Empty<int>();
    }
}