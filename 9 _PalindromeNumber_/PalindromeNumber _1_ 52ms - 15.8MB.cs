public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            //Negative numbers are not palindromes (-121 -> 121-)
            return false;
        }

        int maxPowerOf10BelowX = 1;
        while (maxPowerOf10BelowX*10 <= x)
        {
            int aux = maxPowerOf10BelowX * 10;
            if (aux % 10 != 0 || aux < maxPowerOf10BelowX)
            {
                break;
            }
            maxPowerOf10BelowX = aux;
        }
        while (maxPowerOf10BelowX >= 10)
        {
            int rightMostDigit = x % 10;
            int leftMostDigit = x / maxPowerOf10BelowX;

            if (rightMostDigit != leftMostDigit)
            {
                return false;
            }

            x = (x - leftMostDigit*maxPowerOf10BelowX) / 10;
            maxPowerOf10BelowX /= 100;
        }
        return true;
        }
}
