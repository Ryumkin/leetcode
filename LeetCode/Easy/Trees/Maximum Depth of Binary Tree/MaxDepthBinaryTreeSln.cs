public class MaxDepthBinaryTreeSln
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
    
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        var queue = new Queue<TreeNode>();

        var depth = 0;
        queue.Enqueue(root);
        while (queue.Any())
        {
            depth++;
            var nodes = queue.Count;

            for (int i = 0; i < nodes; i++)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        return depth;
    }
}
