public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";

        int[] result = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int digit1 = num1[i] - '0';

            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int digit2 = num2[j] - '0';
                int tempRes = digit1 * digit2 + result[i + j + 1];

                result[i + j + 1] = tempRes % 10;
                result[i + j] += tempRes / 10;
            }
        }

        StringBuilder sb = new StringBuilder(result.Length);
        int start = result[0] == 0 ? 1 : 0;

        for (int i = start; i < result.Length; i++) sb.Append(result[i]);

        return sb.ToString();
    }
}
