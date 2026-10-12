function searchInsert(nums: number[], target: number): number {
    const len = nums.length
    let index = Math.floor(len/2)

    if (len <= 0) return 0
    if (len == 1) return target > nums[index] ? 1 : 0
    if (target < nums[index]) return searchInsert(nums.slice(0,index), target)
    if (target > nums[index]) return index + searchInsert(nums.slice(index), target)
    return index
};


// Apparently, slice runs through all index positions, making what should be a O(log n) solution into O(n)
// Also, slice creates new arrays, using more memory
// Third, recursion runs the risk of hitting the maximum call stack size for very large arrays
