public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> result = new List<string>();

        Generate(new StringBuilder(), result, n, n);

        return result;
    }

    private void Generate(StringBuilder sb, IList<string> store, int left, int right)
    {
        if (left > right) return;

        if (left > 0)
        {
            Generate(sb.Append('('), store, left - 1, right);
            sb.Length = sb.Length - 1;
        }

        if (right > 0)
        {
            Generate(sb.Append(')'), store, left, right - 1);
            sb.Length = sb.Length - 1;
        }

        if (left == 0 && right == 0) store.Add(sb.ToString());
    }
}
