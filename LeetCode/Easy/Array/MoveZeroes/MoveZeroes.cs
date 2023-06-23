public class MoveZeroesSolution {
    public void MoveZeroes(int[] nums)
    {
        int left = 0, right = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                right++;
                continue;
            }

            (nums[left], nums[right]) = (nums[right++], nums[left++]);
        }
    }
}