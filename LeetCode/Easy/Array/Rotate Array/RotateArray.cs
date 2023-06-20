public class RotateArray {
    public void Rotate(int[] nums, int k) {
        if(k==0)
            return;
        var length = nums.Length;
        k = k % length;
        Reverse(nums);
        Reverse(nums.AsSpan().Slice(0, k));
        Reverse(nums.AsSpan().Slice(k, length - k));
    }

    public void Reverse(Span<int> nums){
        int start = 0;
        int end = nums.Length - 1;
        while (start < end){
            (nums[start], nums[end]) = (nums[end--],nums[start++]);
        }
    }
}