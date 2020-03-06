public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        List<int> list = heights.ToList();
        Stack<int> stack = new Stack<int>();
        int result = 0;

        list.Add(0);

        for (int i = 0; i < list.Count; i++)
        {
            if (!stack.Any() || list[i] > list[stack.Peek()])
            {
                stack.Push(i);
            }
            else
            {
                while (stack.Any() && list[stack.Peek()] >= list[i])
                {
                    int h = list[stack.Pop()];
                    int w = !stack.Any() ? i : i - stack.Peek() - 1;

                    result = Math.Max(h * w, result);
                }

                stack.Push(i);
            }
        }

        return result;
    }
}
