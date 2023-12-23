public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length -1;
        do 
        {
            int middle = (left + right) / 2;
            if (nums[middle] == target) {
                return middle;
            }
            if (target > nums[middle]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        } while ( left <= right);
        return -1;
    }
}