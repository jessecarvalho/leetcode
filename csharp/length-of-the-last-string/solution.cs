public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words;
        words = s.Split(" ");
        int lengthToReturn = 0;
        for (var i = 0; i < words.Length; i++) {
            if (words[i].Length > 0) {
                lengthToReturn = words[i].Length;
            }
        }
        return lengthToReturn;
    }
}