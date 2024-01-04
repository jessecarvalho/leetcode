public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
        for (int i = 0; i < sentences.Length; i++) {
            string[] words = sentences[i].Split(" ");
            if (words.Count() > max) {
                max = words.Count(); 
            }
        }
        return max;
    }
}