public class Solution
{
    public int[,] GenerateMatrix(int n)
    {
        int[,] result = new int[n, n];
        int num = 1;
        int mid = n / 2;
        bool odd = n % 2 == 1;

        for (int start = 0; start < mid; start++)
        {
            int end = n - start - 1;

            for (int i = start; i < end; i++) result[start, i] = num++;
            for (int i = start; i < end; i++) result[i, end] = num++;
            for (int i = end; i > start; i--) result[end, i] = num++;
            for (int i = end; i > start; i--) result[i, start] = num++;
        }

        if (odd) result[mid, mid] = num;

        return result;
    }
}
