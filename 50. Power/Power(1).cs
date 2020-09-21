// Runtime: 48 ms, faster than 65.14% of C# online submissions for Pow(x, n).
// Memory Usage: 15 MB, less than 76.65% of C# online submissions for Pow(x, n).
public class Solution {
    public double MyPow(double x, int n)
    {
        bool neg = n < 0;
        double p;

        if (n == 0)
            return 1;
        if (n == 1)
            return x;
        if (n == -1)
            return 1/x;

        if (neg)
            n *= -1;

        p = MyPow(x, n / 2);
        p *= p;

        if (n % 2 == 1)
            p *= x;

        if (neg && double.IsInfinity(p))
            return 0;
        if (double.IsInfinity(p))
            return 0;
        if (neg)
            return 1 / p;

        return p;
    }
}