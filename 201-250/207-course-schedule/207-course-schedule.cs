public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> coursePrerequisites = new Dictionary<int, List<int>>();

        foreach (int[] prerequisite in prerequisites)
        {
            if (!coursePrerequisites.ContainsKey(prerequisite[0]))
            {
                coursePrerequisites.Add(prerequisite[0], new List<int>());
            }

            coursePrerequisites[prerequisite[0]].Add(prerequisite[1]);
        }

        HashSet<int> finishedCourses = new HashSet<int>();

        for (int i = 0; i < numCourses; i++)
        {
            if (finishedCourses.Contains(i))
            {
                continue;
            }

            HashSet<int> seen = new HashSet<int>();

            if (HasLoop(coursePrerequisites, i, finishedCourses, seen))
            {
                return false;
            }
        }

        return true;
    }

    private bool HasLoop(Dictionary<int, List<int>> prerequisities, int course, HashSet<int> finished, HashSet<int> seen)
    {
        finished.Add(course);

        if (!prerequisities.ContainsKey(course))
        {
            return false;
        }

        seen.Add(course);

        foreach (int p in prerequisities[course])
        {
            if (seen.Contains(p))
            {
                return true;
            }

            if (finished.Contains(p))
            {
                continue;
            }

            if (HasLoop(prerequisities, p, finished, seen))
            {
                return true;
            }
        }

        seen.Remove(course);

        return false;
    }
}
