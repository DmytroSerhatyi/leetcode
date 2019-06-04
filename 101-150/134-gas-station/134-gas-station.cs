public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int start = 0;
        int totalGas = 0;
        int totalCost = 0;
        int left = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];
            left += gas[i] - cost[i];

            if (left < 0)
            {
                start = i + 1;
                left = 0;
            }
        }

        return totalGas >= totalCost ? start : -1;
    }
}
