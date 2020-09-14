public class Solution {
    public bool IsValid(string s)
        {
            if (s.Length == 0) { return true; }
            Dictionary<char, int> d = new Dictionary<char, int> { { '(', 1 },{ ')', 1 },{ '{', 2 },{ '}', 2 },{ '[', 3 },{ ']', 3} };
            List<char> stack = new List<char>();
            for (int i=0; i<s.Length; i++)
            {
                if ("{[(".Contains(s[i]))
                {
                    stack.Add(s[i]);
                }
                else
                {
                    if (stack.Count == 0 || d[s[i]] != d[stack.Last()])
                    {
                        return false;
                    }
                    stack.RemoveAt(stack.Count()-1);
                }
            }
            if (stack.Count > 0) { return false; }
            return true;
        }
}
