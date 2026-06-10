class Solution {
  public void gameOfLife(int[][] board) {
    int m = board.length;
    int n = board[0].length;

    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        int neighbourCount = 0;
        int current = board[i][j];

        for (int k = i - 1; k <= i + 1; k++) {
          for (int l = j - 1; l <= j + 1; l++) {
            if (k == i && l == j) {
              continue;
            }

            neighbourCount += getNeighbour(k, l, board);
          }
        }

        if ((current == 1 && (neighbourCount == 2 || neighbourCount == 3)) || (current == 0 && neighbourCount == 3)) {
          board[i][j] = current | 2;
        }
      }
    }

    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        board[i][j] = board[i][j] >> 1;
      }
    }
  }

  private int getNeighbour(int i, int j, int[][] board) {
    if (i < 0 || j < 0 || i >= board.length || j >= board[0].length) {
      return 0;
    }

    return board[i][j] & 1;
  }
}
