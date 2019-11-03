public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> list = new Dictionary<int, List<int>>();
        int[] degrees = new int[numCourses];
        List<int> result = new List<int>();
        Queue<int> q = new Queue<int>();

        foreach (int[] p in prerequisites)
        {
            degrees[p[0]]++;

            if (!list.ContainsKey(p[1]))
            {
                list[p[1]] = new List<int>();
            }

            list[p[1]].Add(p[0]);
        }

        for (int i = 0; i < numCourses; i++)
        {
            if (degrees[i] == 0)
            {
                q.Enqueue(i);
            }
        }

        while (q.Any())
        {
            int course = q.Dequeue();

            result.Add(course);

            if (list.ContainsKey(course))
            {
                foreach (int p in list[course])
                {
                    degrees[p]--;

                    if (degrees[p] == 0)
                    {
                        q.Enqueue(p);
                    }
                }
            }
        }

        return result.Count == numCourses ? result.ToArray() : new int[0];
    }
}
