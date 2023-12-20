public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> currentSubstring = new List<char>();
        int maxLength = 0;
        foreach (char letter in s) {
            if (currentSubstring.Contains(letter)) {
                int index = currentSubstring.IndexOf(letter);
                currentSubstring.RemoveRange(0, index + 1);
            }
            currentSubstring.Add(letter);
            if (currentSubstring.Count > maxLength) {
                maxLength = currentSubstring.Count;
            }
        }
        return maxLength;
    }
}