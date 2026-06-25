import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

class Solution {
  public String getHint(String secret, String guess) {
    int bulls = 0;
    int cows = 0;
    Map<Character, Integer> possibleCows = new HashMap<Character, Integer>();
    Set<Integer> indicesToSkip = new HashSet<Integer>();

    for (int i = 0; i < secret.length(); i++) {
      char secretChar = secret.charAt(i);
      char guessChar = guess.charAt(i);

      if (secretChar == guessChar) {
        bulls++;
        indicesToSkip.add(i);
      } else {
        possibleCows.merge(secretChar, 1, Integer::sum);
      }
    }

    for (int i = 0; i < guess.length(); i++) {
      if (indicesToSkip.contains(i)) {
        continue;
      }

      char guessChar = guess.charAt(i);
      int count = possibleCows.getOrDefault(guessChar, 0);

      if (count > 0) {
        cows++;
        possibleCows.merge(guessChar, -1, Integer::sum);
      }
    }

    return "%sA%sB".formatted(bulls, cows);
  }
}
