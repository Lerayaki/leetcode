public class Solution {
    public int Reverse(int x) {
        bool negFlag = (x < 0);
        int ix = 0;

        if (negFlag)
        {
            x = -x;
        }

        while (x > 0)
        {
            if (int.MaxValue/10 < ix)
            {
                return 0;
            }
            ix *= 10;
            ix += x % 10;
            x /= 10;
        }

        if (negFlag)
        {
            return -ix;
        }
        return ix;
    }
}
