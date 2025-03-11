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

    public int? GetMaxPathAvailableToPassThroughParent(TreeNode node)
    {
        if (node == null)
        {
            return null;
        }

        int? leftMax = GetMaxPathAvailableToPassThroughParent(node.left);
        int? rightMax = GetMaxPathAvailableToPassThroughParent(node.right);

        if (leftMax != null)
        {
            GlobalMax = Math.Max(GlobalMax, leftMax.Value);
            GlobalMax = Math.Max(GlobalMax, node.val + leftMax.Value);
        }

        if (rightMax != null)
        {
            GlobalMax = Math.Max(GlobalMax, rightMax.Value);
            GlobalMax = Math.Max(GlobalMax, node.val + rightMax.Value);
        }

        if (leftMax != null && rightMax != null)
        {
            GlobalMax = Math.Max(GlobalMax, leftMax.Value + node.val + rightMax.Value);
        }

        int maxPathThroughNode = node.val;
        if (leftMax != null)
        {
            maxPathThroughNode = Math.Max(maxPathThroughNode, leftMax.Value + node.val);
        }

        if (rightMax != null)
        {
            maxPathThroughNode = Math.Max(maxPathThroughNode, rightMax.Value + node.val);
        }

        return maxPathThroughNode;
    }
}
