public class Solution
{
    public string ReverseWords(string s)
    {
        return string.Join(' ', s.Split(' ').Where(c => c.Length > 0).Reverse());
    }
}
