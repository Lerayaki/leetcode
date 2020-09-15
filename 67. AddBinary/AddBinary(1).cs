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
            int x = Int32.Parse(b[b.Length - i].ToString());
            int y = Int32.Parse(a[a.Length - i].ToString());
            c = $"{(x+y+r)%2}{c}";
            r = (x+y+r)/2;
        }

        while (i <= a.Length)
        {
            int y = Int32.Parse(a[a.Length - i].ToString());
            c = $"{(y + r) % 2}{c}";
            r = (y + r) / 2;
            i++;
        }
        if (r != 0)
            return $"{r}{c}";
        return c;
    }
}
