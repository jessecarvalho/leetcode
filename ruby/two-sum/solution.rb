def two_sum(nums, target)
    num_indices = {}

    nums.each_with_index do |num, index|
        complement = target - num
        if num_indices.key?(complement)
            return [num_indices[complement], index]
        end
        num_indices[num] = index unless num_indices.key?(num)
    end

    return []
end