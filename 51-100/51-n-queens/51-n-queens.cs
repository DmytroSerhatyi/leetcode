public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<int, HashSet<int>> coords = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < n; i++)
        {
            HashSet<int> xs = new HashSet<int>();

            for (int j = 0; j < n; j++)
            {
                xs.Add(j);
            }

            coords.Add(i, xs);
        }

        SetQueen(0, result, new char[n][], n, coords);

        return result;
    }

    private void SetQueen(int quantity, IList<IList<string>> result, char[][] tempResult, int n, Dictionary<int, HashSet<int>> coords)
    {
        if (quantity == n)
        {
            IList<string> l = new List<string>();

            foreach (char[] chars in tempResult)
            {
                l.Add(new string(chars));
            }

            result.Add(l);

            return;
        }

        HashSet<int> xs = coords[quantity];

        foreach (int x in xs)
        {
            Dictionary<int, HashSet<int>> coordsCopy = new Dictionary<int, HashSet<int>>(coords);
            char[][] tempResultCopy = new char[tempResult.Length][];

            for (int i = quantity; i < n; i++)
            {
                coordsCopy[i] = new HashSet<int>(coordsCopy[i]);
            }

            coordsCopy.Remove(quantity);
            tempResult.CopyTo(tempResultCopy, 0);

            char[] charsTemp = new char[n];

            for (int i = 0; i < n; i++)
            {
                charsTemp[i] = i == x ? 'Q' : '.';
            }

            tempResultCopy[quantity] = charsTemp;

            int counter = 1;

            foreach (KeyValuePair<int, HashSet<int>> keyValuePair in coordsCopy)
            {
                coordsCopy[keyValuePair.Key].Remove(x);
                coordsCopy[keyValuePair.Key].Remove(x + counter);
                coordsCopy[keyValuePair.Key].Remove(x - counter);
                counter++;
            }

            SetQueen(quantity + 1, result, tempResultCopy, n, coordsCopy);
        }
    }
}
