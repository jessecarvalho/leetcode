class Solution {
    search(nums: number[], target: number): number {
        let left: number = 0;
        let right: number = nums.length - 1;

        while (left <= right) {
            let middle: number = Math.floor(left + (right - left) / 2);

            if (nums[middle] === target) {
                return middle;
            }

            if (target > nums[middle]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        
        return -1;
    }
}
