public class Solution
{
    public string SimplifyPath(string path)
    {
        string[] parts = path.Split('/');
        Stack<string> stack = new Stack<string>();

        foreach (string part in parts)
        {
            if (part == "" || part == ".") continue;

            if (part == "..")
            {
                if (stack.Any()) stack.Pop();

                continue;
            }

            stack.Push(part);
        }

        if (!stack.Any()) return "/";

        StringBuilder result = new StringBuilder();

        while (stack.Any()) result.Insert(0, stack.Pop()).Insert(0, '/');

        return result.ToString();
    }
}
