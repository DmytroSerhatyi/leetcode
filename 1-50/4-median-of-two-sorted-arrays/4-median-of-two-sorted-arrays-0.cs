public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int target = (nums1.Length + nums2.Length) / 2;
        int[] helper = new int[target + 1];
        int i1 = 0;
        int i2 = 0;

        while (i1 + i2 != target + 1)
        {
            if (i1 == nums1.Length)
            {
                helper[i1 + i2] = nums2[i2++];
            }
            else if (i2 == nums2.Length)
            {
                helper[i1 + i2] = nums1[i1++];
            }
            else if (nums1[i1] > nums2[i2])
            {
                helper[i1 + i2] = nums2[i2++];
            }
            else
            {
                helper[i1 + i2] = nums1[i1++];
            }
        }

        return (nums1.Length + nums2.Length) % 2 == 0 ? (helper[target] + helper[target - 1]) / 2.0 : helper[target];
    }
}
