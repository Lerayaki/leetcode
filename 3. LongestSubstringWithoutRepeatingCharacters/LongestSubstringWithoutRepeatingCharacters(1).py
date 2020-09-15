class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        rval = 0
        dict = {}
        for i in range(0,len(s)):
            if s[i] in dict:
                rval = max(rval,len(dict))
                aux = dict[s[i]]
                for key in dict.copy():
                    if dict[key] <= aux:
                        dict.pop(key)
                dict[s[i]] = i
            else:
                dict[s[i]] = i
                rval = max(rval,len(dict))
        return rval
