// Runtime: 76 ms, faster than 100.00% of C# online submissions for Longest Happy String.
// Memory Usage: 22.8 MB, less than 47.37% of C# online submissions for Longest Happy String.
public class Solution {
    public string LongestDiverseString(int a, int b, int c)
    {
        string s = string.Empty;
        List<KeyValuePair<char, int>> list = new List<KeyValuePair<char, int>>()
        {
            new KeyValuePair<char, int>('a', a),
            new KeyValuePair<char, int>('b', b),
            new KeyValuePair<char, int>('c', c)
        };

        list.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

        char last = 'd';

        while (true)
        {
            if (list[2].Key != last)
            {
                for (int i = 0; i < 2 && list[2].Value > 0; i++)
                {
                    s += list[2].Key;
                    list[2] = new KeyValuePair<char, int>(list[2].Key, list[2].Value - 1);
                    last = list[2].Key;
                }
            }
            else if (list[1].Value > 0)
            {
                s += list[1].Key;
                list[1] = new KeyValuePair<char, int>(list[1].Key, list[1].Value - 1);
                last = list[1].Key;
            }
            if (last == list[2].Key && list[1].Value+list[0].Value == 0)
                break;

            list.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        }

        return s;
    }
}