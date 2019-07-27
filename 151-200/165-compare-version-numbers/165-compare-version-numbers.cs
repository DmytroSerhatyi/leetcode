public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        int l = Math.Max(v1.Length, v2.Length);

        for (int i = 0; i < l; i++)
        {
            int pv1 = i < v1.Length ? int.Parse(v1[i]) : 0;
            int pv2 = i < v2.Length ? int.Parse(v2[i]) : 0;

            if (pv1 > pv2)
            {
                return 1;
            }

            if (pv2 > pv1)
            {
                return -1;
            }
        }

        return 0;
    }
}
