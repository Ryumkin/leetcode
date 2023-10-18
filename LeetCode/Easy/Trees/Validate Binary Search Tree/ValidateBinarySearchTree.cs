public class ValidateBinarySearchTree
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
    
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }
    
    public bool IsValidBST(TreeNode root, int? min, int? max) {
        if (root == null)
        {
            return true;
        }

        if (root.val <= min || root.val >= max)
        {
            return false;
        }

        return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
    }
}
