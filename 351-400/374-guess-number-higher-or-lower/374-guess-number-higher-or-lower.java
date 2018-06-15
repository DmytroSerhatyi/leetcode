/* The guess API is defined in the parent class GuessGame.
   @param num, your guess
   @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
      int guess(int num); */

public class Solution extends GuessGame {
    public int guessNumber(int n) {
        int low = 0;

        while (low < n) {
            int mid = (n - low) / 2 + low;

            int answer = guess(mid);

            if (answer == 0) {
                return mid;
            } else if (answer > 0) {
                low = mid + 1;
            } else {
                n = mid;
            }
        }

        return n;
    }
}
