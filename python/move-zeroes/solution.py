def moveZeroes(nums):
    lastZero = 0
    for i in range(len(nums)):
        if nums[i] != 0:
            nums[lastZero], nums[i] = nums[i], nums[lastZero]
            lastZero += 1
    print(nums)