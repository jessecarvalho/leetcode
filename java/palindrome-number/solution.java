public class Solution {
    public boolean isPalindrome(int x) {
        String[] digits = Integer.toString(x).split("");
        for (int i = 0; i < digits.length / 2; i++) {
            if (!digits[i].equals(digits[digits.length - 1 - i])) {
                return false;
            }
        }
        return true;
    }
}
