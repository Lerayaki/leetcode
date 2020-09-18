public class Solution {
    public string LongestDiverseString(int a, int b, int c)
    {
        string s = string.Empty;

        while (a > 0 || b > 0 || c > 0)
        {
            if (a > 0 && (s.Length == 0 || s[s.Length-1] != a))
            {
                for (int i=0; i<2; i++)
                {
                    s += 'a';
                    a--;
                    if (a == 0)
                        break;
                }
                if (b == 0 && c == 0)
                {
                    break;
                }
            }
            if (b > 0 && (s.Length == 0 || s[s.Length - 1] != b))
            {
                for (int i = 0; i < 2; i++)
                {
                    s += 'b';
                    b--;
                    if (b == 0)
                        break;
                }
                if (a == 0 && c == 0)
                {
                    break;
                }
            }
            if (c > 0 && (s.Length == 0 || s[s.Length - 1] != c))
            {
                for (int i = 0; i < 2; i++)
                {
                    s += 'c';
                    c--;
                    if (c == 0)
                        break;
                }
                if (b == 0 && a == 0)
                {
                    break;
                }
            }
        }

        return s;
    }
}