func twoSum(nums []int, target int) []int {
    numIndices := make(map[int]int)

    for i, num := range nums {
        complement := target - num
        if idx, found := numIndices[complement]; found {
            return []int{idx, i}
        }
        if _, exists := numIndices[num]; !exists {
            numIndices[num] = i
        }
    }
    return []int{}
}