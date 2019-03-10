public class Solution
{
    public void SortColors(int[] nums)
    {
        if (nums.Length < 2) return;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int current = nums[i];
            int next = nums[i + 1];

            if (current <= next) continue;

            int j = i;

            while (j >= 0 && nums[j] > next) j--;
            j++;

            int temp = nums[j];

            nums[j] = next;
            nums[i + 1] = temp;
            i--;
        }
    }
}
