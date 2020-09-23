// Runtime: 240 ms, faster than 62.73% of C# online submissions for Plus One.
// Memory Usage: 29.6 MB, less than 92.55% of C# online submissions for Plus One.
public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int[] plusOne = new int[0];
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
            if (i == 0)
            {
                plusOne = new int[digits.Length + 1];
                plusOne[0] = 1;
                digits.CopyTo(plusOne, 1);
            }
        }
        return plusOne;
    }
}