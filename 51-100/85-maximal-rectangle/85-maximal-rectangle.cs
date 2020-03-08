public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
        {
            return 0;
        }

        int max = 0;
        int[] rows = new int[matrix[0].Length];

        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length; c++)
            {
                rows[c] = matrix[r][c] == '1' ? rows[c] + 1 : 0;
            }

            max = Math.Max(max, CalculateMaxRect(rows));
        }

        return max;
    }

    private int CalculateMaxRect(int[] heights)
    {
        int i = 0;
        int max = 0;
        int top;
        int area;
        Stack<int> stack = new Stack<int>();

        while (i < heights.Length)
        {
            if (!stack.Any() || heights[stack.Peek()] <= heights[i])
            {
                stack.Push(i++);
            }
            else
            {
                while (stack.Any() && heights[stack.Peek()] > heights[i])
                {
                    top = stack.Pop();
                    area = heights[top] * (stack.Any() ? i - stack.Peek() - 1 : i);
                    max = Math.Max(max, area);
                }

                stack.Push(i);
            }
        }

        while (stack.Any())
        {
            top = stack.Pop();
            area = heights[top] * (stack.Any() ? i - stack.Peek() - 1 : i);
            max = Math.Max(max, area);
        }

        return max;
    }
}
