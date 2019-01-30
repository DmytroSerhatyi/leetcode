public class Solution
{
    public string GetPermutation(int n, int k)
    {
        List<int> nums = new List<int>();
        StringBuilder sb = new StringBuilder(n);
        int totalCapacity = 1;
        int temp = n;

        while (temp > 1)
        {
            totalCapacity *= temp;
            temp--;
        }

        for (int i = 1; i <= n; i++) nums.Add(i);

        while (n > 0)
        {
            int sectionCapacity = totalCapacity / n;
            int section = 1;

            while (k > sectionCapacity * section) section++;

            section--;
            sb.Append(nums[section]);
            nums.RemoveAt(section);
            k -= sectionCapacity * section;
            totalCapacity /= n;
            n--;
        }

        return sb.ToString();
    }
}
