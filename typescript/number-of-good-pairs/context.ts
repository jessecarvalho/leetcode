function numIdenticalPairs(nums: number[]): number {
    let counter: number = 0;
    for (let i: number = 0; i < nums.length - 1; i++) {
        for (let j: number = i + 1; j < nums.length; j++) {
            if (nums[i] === nums[j]) {
                counter += 1;
            }
        }
    }
    return counter;
}