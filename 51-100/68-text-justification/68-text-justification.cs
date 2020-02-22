public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> result = new List<string>();
        IList<string> tempResult = new List<string>();
        int chars = 0;

        foreach (string word in words)
        {
            if (chars + tempResult.Count() + word.Length <= maxWidth)
            {
                tempResult.Add(word);
                chars += word.Length;
            }
            else
            {
                result.Add(GenerateString(tempResult, maxWidth, chars));
                tempResult = new List<string> { word };
                chars = word.Length;
            }
        }

        if (tempResult.Any())
        {
            result.Add(GenerateString(tempResult, maxWidth, chars, true));
        }

        return result;
    }

    private string GenerateString(IList<string> tempResult, int maxWidth, int chars, bool last = false)
    {
        int spaces = tempResult.Count() - 1;
        int freeSpace = maxWidth - spaces - chars;
        int spaceLength = last ? 1 : 1 + freeSpace / (spaces == 0 ? 1 : spaces);
        int remainder = last ? 0 : maxWidth - chars - spaceLength * spaces;
        StringBuilder s = new StringBuilder();

        for (int i = 0; i < spaces; i++)
        {
            int tempSpaceLength = spaceLength;

            if (remainder > 0)
            {
                tempSpaceLength++;
                remainder--;
            }

            s.Append(tempResult[i]);
            s.Append(' ', tempSpaceLength);
        }

        s.Append(tempResult.Last());
        s.Append(' ', maxWidth - s.Length);

        return s.ToString();
    }
}
