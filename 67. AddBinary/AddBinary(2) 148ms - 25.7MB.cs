public class Solution {
    public string AddBinary(string a, string b)
    {
        int r = 0;
        string c = string.Empty;

        if (a.Length < b.Length)
        {
            string aux = a;
            a = b;
            b = aux;
        }

        int i;
        for (i = 1; i<=b.Length; i++)
        {
            int x = 0;
            if (b[b.Length - i] == '1')
                x++;
            if (a[a.Length - i] == '1')
                x++;

            c = $"{(x+r)%2}{c}";
            r = (x+r)/2;
        }

        if (a.Length == b.Length && r != 0)
            return $"{r}{c}";

        while (i <= a.Length)
        {
            int x = 0;
            if (a[a.Length - i] == '1')
                x = 1;
            c = $"{(x + r) % 2}{c}";
            r = (x + r) / 2;
            i++;
        }
        if (r != 0)
            return $"{r}{c}";
        return c;
    }
}
