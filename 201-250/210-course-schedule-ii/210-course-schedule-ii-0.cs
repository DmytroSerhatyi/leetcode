public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> list = new Dictionary<int, List<int>>();
        List<int> result = new List<int>();

        foreach (int[] p in prerequisites)
        {
            if (!list.ContainsKey(p[0]))
            {
                list[p[0]] = new List<int>();
            }

            list[p[0]].Add(p[1]);
        }

        for (int i = 0; i < numCourses; i++)
        {
            if (FindOrderInternal(result, list, i, new List<int>()))
            {
                return new int[0];
            }
        }

        return result.ToArray();
    }

    private bool FindOrderInternal(List<int> result, Dictionary<int, List<int>> list, int course, List<int> loop)
    {
        if (loop.Contains(course))
        {
            return true;
        }

        if (result.Contains(course))
        {
            return false;
        }

        if (!list.ContainsKey(course))
        {
            result.Add(course);

            return false;
        }

        loop.Add(course);

        foreach (int requirement in list[course])
        {
            if (FindOrderInternal(result, list, requirement, loop))
            {
                return true;
            }
        }

        loop.RemoveAt(loop.Count - 1);
        result.Add(course);

        return false;
    }
}
