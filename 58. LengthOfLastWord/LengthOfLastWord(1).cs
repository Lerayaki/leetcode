// Runtime: 120 ms, faster than 19.95% of C# online submissions for Length of Last Word.
// Memory Usage: 22.2 MB, less than 30.55% of C# online submissions for Length of Last Word.
public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 0)
            return 0;
        
        int j=s.Length-1;
        while (s[j] == ' '){
            j--;
            
            if (j<0)
                return 0;
        }
        
        int i=j;
        while (s[i] != ' '){
            i--;
            if (i<0)
                return j-i;
        }
        return j-i;
    }
}