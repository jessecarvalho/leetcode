public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        int numsLength = nums.Length;

        int[] x = new int[numsLength / 2];
        int[] y = new int[numsLength / 2];
        Array.Copy(nums, 0, x, 0, n);
        Array.Copy(nums, n, y, 0, n);

        int[] results = new int[numsLength];

        for (var i = 0; i < n; i++) {
            results[i * 2] = x[i];
            results[i * 2 + 1] = y[i]; 
        } 

        return results;
    }
}