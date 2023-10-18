public class SymmetricTree
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
    
    public bool Check(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
        {
            return left == right;
        }

        return left.val == right.val && Check(left.left, right.right) && Check(left.right, right.left);
    }
    
    public bool IsSymmetric(TreeNode root)
    {
        return Check(root.left, root.right);
    }
}
