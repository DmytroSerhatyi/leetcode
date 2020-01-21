public class Solution
{
    public int LongestValidParentheses(string s)
    {
        Stack<int> stack = new Stack<int>();
        int result = 0;

        stack.Push(-1);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();

                if (stack.Count() > 0)
                {
                    result = Math.Max(result, i - stack.Peek());
                }
                else
                {
                    stack.Push(i);
                }
            }
        }

        return result;
    }
}
