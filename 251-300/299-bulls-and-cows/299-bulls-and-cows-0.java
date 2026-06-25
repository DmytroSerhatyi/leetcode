class Solution {
  public String getHint(String secret, String guess) {
    int bulls = 0;
    int cows = 0;
    int[] possibleCows = new int[10];
    int[] guessValues = new int[guess.length()];
    int guessValuesMax = 0;

    for (int i = 0; i < secret.length(); i++) {
      int secretVal = Character.getNumericValue(secret.charAt(i));
      int guessVal = Character.getNumericValue(guess.charAt(i));

      if (secretVal == guessVal) {
        bulls++;
      } else {
        possibleCows[secretVal] = ++possibleCows[secretVal];
        guessValues[guessValuesMax++] = guessVal;
      }
    }

    for (int i = 0; i < guessValuesMax; i++) {
      int guessVal = guessValues[i];

      if (possibleCows[guessVal] > 0) {
        cows++;
        possibleCows[guessVal] = --possibleCows[guessVal];
      }
    }

    return bulls + "A" + cows + "B";
  }
}
