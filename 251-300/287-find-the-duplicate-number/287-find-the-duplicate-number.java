class Solution {
  public int findDuplicate(int[] nums) {
    int low = 1;
    int high = nums.length - 1;

    while (low < high) {
      int matchLow = 0;
      int target = (high + low) / 2;

      for (int i = 0; i < nums.length; i++) {
        if (nums[i] <= target) {
          matchLow++;
        }
      }

      if (matchLow > target) {
        high = target;
      } else {
        low = target + 1;
      }
    }

    return low;
  }
}
