public class Solution {
    public bool IsPalindrome(int x) {
        var digits = x.ToString().Select(digit => digit.ToString()).ToArray();
        for (var i = 0; i < digits.Length - 1; i++) {
            if (digits[i] == digits[digits.Length - 1 - i]) {
                continue;
            }
            return false;
        }
        return true;
    }
}
