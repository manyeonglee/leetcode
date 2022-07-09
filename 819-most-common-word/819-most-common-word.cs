public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
            HashSet<string> set = new HashSet<string>(banned);

            foreach (var str in paragraph.Replace("!", " ")
                                         .Replace("?", " ")
                                         .Replace("'", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(".", " ")
                                         .ToLower()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .GroupBy(x => x)
                                         .OrderByDescending(x => x.Count())
                                         .Select(x => x.Key))
                if (!set.Contains(str))
                    return str;

            return string.Empty;
    }
}