class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        dict = {}
        for i in range(0,len(nums)):
            complement = target -nums[i]
            if complement in dict:
                return [i, dict[complement]]
            dict[nums[i]] = i
