namespace Algorithms.LeetCode;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class binary_tree_maximum_path_sum
{
    private int GlobalMax = 0;

    public int MaxPathSum(TreeNode root)
    {
        GlobalMax = root.val;
        GetMaxPathAvailableToPassThroughParent(root);
        return GlobalMax;
    }

    public int GetMaxPathAvailableToPassThroughParent(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftMax = GetMaxPathAvailableToPassThroughParent(node.left);
        int rightMax = GetMaxPathAvailableToPassThroughParent(node.right);
        GlobalMax = Math.Max(GlobalMax, leftMax);
        GlobalMax = Math.Max(GlobalMax, rightMax);
        GlobalMax = Math.Max(GlobalMax, node.val + leftMax);
        GlobalMax = Math.Max(GlobalMax, node.val + rightMax);
        GlobalMax = Math.Max(GlobalMax, leftMax + node.val + rightMax);

        int maxPathThroughNode = Math.Max(node.val, node.val + leftMax);
        return Math.Max(maxPathThroughNode, node.val + rightMax);
    }
}
