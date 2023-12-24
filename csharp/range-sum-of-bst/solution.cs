public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null) {
            return 0;
        }

        int sum = 0;

        if (root.val >= low && root.val <= high) {
            sum += root.val;
        }

        sum += RangeSumBST(root.left, low, high);
        sum += RangeSumBST(root.right, low, high);
        return sum;
    }
}