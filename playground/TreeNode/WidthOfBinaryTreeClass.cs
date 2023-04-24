namespace playground.TreeNode;

public class WidthOfBinaryTreeClass
{
    public static int WidthOfBinaryTree(TreeNode? root)
    {
        if (root is null)
            return 0;

        int maxWidth = 0;
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));

        while (queue.Count > 0)
        {
            int size = queue.Count;
            int left = queue.Peek().Item2;
            int right = left;

            for (int i = 0; i < size; i++)
            {
                (TreeNode node, int index) = queue.Dequeue();
                right = index;

                if (node.left is not null)
                    queue.Enqueue((node.left, 2 * index));

                if (node.right is not null)
                    queue.Enqueue((node.right, 2 * index + 1));
            }
            maxWidth = Math.Max(maxWidth, right - left + 1);
        }
        return maxWidth;
    }
}
