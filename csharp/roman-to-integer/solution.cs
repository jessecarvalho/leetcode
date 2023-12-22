public class Solution {
    
    private int Translate(char letter) {
        switch (letter) {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M': 
                return 1000;
            default:
                return 0;
        }
    }
    
    public int RomanToInt(string s) {

        int sum = 0;

        for (int i = 0; i < s.Length; i++) {
            int current = Translate(s[i]);
            int next = i + 1 < s.Length ? Translate(s[i + 1]) : 0;
            if (current < next) {
                sum -= current;
            } else {
                sum += current;
            }
        }

        return sum;
    }
}