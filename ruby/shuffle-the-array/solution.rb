def shuffle(nums, n)
    x = nums[0, n]
    y = nums[n..-1]

    results = Array.new(nums.length)

    n.times do |i|
        results[i * 2] = x[i]
        results[i * 2 + 1] = y[i]
    end

    results
end
