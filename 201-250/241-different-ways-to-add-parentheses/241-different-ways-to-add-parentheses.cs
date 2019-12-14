public class Solution
{
    public IList<int> DiffWaysToCompute(string input)
    {
        return DiffWaysToCompute(input, new Dictionary<string, IList<int>>());
    }

    private IList<int> DiffWaysToCompute(string input, Dictionary<string, IList<int>> map)
    {
        if (map.ContainsKey(input))
        {
            return map[input];
        }

        List<int> list = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                continue;
            }

            string left = input.Substring(0, i);
            IList<int> leftList = DiffWaysToCompute(left, map);
            string right = input.Substring(i + 1);
            IList<int> rightList = DiffWaysToCompute(right, map);

            foreach (int l in leftList)
            {
                foreach (int r in rightList)
                {
                    int res;

                    switch (input[i])
                    {
                        case '+':
                            res = l + r;
                            break;
                        case '-':
                            res = l - r;
                            break;
                        default:
                            res = l * r;
                            break;
                    }

                    list.Add(res);
                }
            }
        }

        if (!list.Any())
        {
            list.Add(int.Parse(input));
        }

        map[input] = list;

        return list;
    }
}
