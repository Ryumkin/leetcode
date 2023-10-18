using System.Reflection.Metadata.Ecma335;

public class SortedArrayToBSTSln
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Construct(nums, 0, nums.Length-1);
    }

    private TreeNode Construct(int[] nums, int min, int max)
    {
        if (min > max)
        {
            return null;
        }
        var middle = min + (max - min) / 2;
        var node = new TreeNode();
        node.val = nums[middle];
        node.left = Construct(nums, min, middle - 1);
        node.right = Construct(nums, middle + 1, max);
        return node;
    }
}
