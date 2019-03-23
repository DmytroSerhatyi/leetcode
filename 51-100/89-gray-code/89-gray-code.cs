public class Solution
{
    public IList<int> GrayCode(int n)
    {
        IList<int> result = new List<int> { 0 };

        if (n == 0) return result;

        result.Add(1);

        for (int i = 1; i < n; i++)
        {
            int index = result.Count - 1;

            while (index >= 0)
            {
                int temp = result[index] ^ (1 << i);

                result.Add(temp);
                index--;
            }
        }

        return result;
    }
}
