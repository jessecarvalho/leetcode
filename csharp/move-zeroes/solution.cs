public class Solution {
    public void MoveZeroes(int[] nums) {
        int lastZero = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                int aux = nums[lastZero];
                nums[lastZero] = nums[i];
                nums[i] = aux;
                lastZero++;
            }
        }
        Console.WriteLine(nums);
    }
}