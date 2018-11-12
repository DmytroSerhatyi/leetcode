public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();

        if (digits.Length < 1) return result;

        Dictionary<char, string> map = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };
        string answer = "";

        Search(0, digits, answer, result, map);

        return result;
    }

    private void Search(int index, string digits, string answer, IList<string> storage, Dictionary<char, string> map)
    {
        if (index == digits.Length) storage.Add(answer);
        else foreach (char c in map[digits[index]]) Search(index + 1, digits, answer + c, storage, map);
    }
}
