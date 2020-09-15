# Runtime: 72 ms, faster than 19.25% of Python3 online submissions for Roman to Integer.
# Memory Usage: 13.9 MB, less than 31.53% of Python3 online submissions for Roman to Integer.
class Solution:
    def romanToInt(self, s: str) -> int:
        map_dict = {'I': 1, 
                    'V': 5, 
                    'X': 10, 
                    'L': 50, 
                    'C': 100, 
                    'D': 500, 
                    'M': 1000}

        decimal = 0
        i = len(s)-1
        while i >= 0:
            decimal = decimal + map_dict[s[i]]
            if (i > 0 and map_dict[s[i-1]] < map_dict[s[i]]):
                decimal = decimal - map_dict[s[i-1]]
                i = i - 1
            i = i - 1
        return decimal