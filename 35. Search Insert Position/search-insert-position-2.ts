function searchInsert(nums: number[], target: number): number {
    let left = 0
    let right = nums.length - 1

    while (left <= right){
        let midpoint = Math.floor((right+left)/2)
		// let midpoint = (right + left) >> 1
		// Bitwise operator (>>), slightlty faster division

        if (target > nums[midpoint]) {
            left = midpoint + 1
        } else if (target < nums[midpoint]) {
            right = midpoint - 1
        } else {
            return midpoint
        }
    }

    return left
};

