class Solution {
  public int[] countBits(int n) {
    int[] dp = new int[n + 1];
    int low = 1;

    for (int i = 1; i <= n; i++) {
      if (i == low * 2) {
        low = i;
      }

      dp[i] = dp[i - low] + 1;
    }

    return dp;
  }
}
