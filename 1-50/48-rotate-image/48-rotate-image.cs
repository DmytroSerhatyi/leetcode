public class Solution
{
    public void Rotate(int[,] matrix)
    {
        int length = matrix.GetLength(0);

        for (int i = 0; i < length / 2; i++)
        {
            int start = i;
            int end = length - 1 - i;

            for (int step = 0; step < end - start; step++)
            {
                int temp = matrix[start, start + step];

                matrix[start, start + step] = matrix[end - step, start];
                matrix[end - step, start] = matrix[end, end - step];
                matrix[end, end - step] = matrix[start + step, end];
                matrix[start + step, end] = temp;
            }
        }
    }
}
