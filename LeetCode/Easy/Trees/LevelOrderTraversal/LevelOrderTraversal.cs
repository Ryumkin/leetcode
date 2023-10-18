using System.Reflection.Metadata.Ecma335;

public class LevelOrderTraversal
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
    
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        IList<IList<int>> results = new List<IList<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        while (queue.Any())
        {
            var nodes = queue.Count;
            var layer = new List<int>();
            for (int i = 0; i < nodes; i++)
            {
                var node = queue.Dequeue();
                layer.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            
            results.Add(layer);
        }

        return results;
    }
}
