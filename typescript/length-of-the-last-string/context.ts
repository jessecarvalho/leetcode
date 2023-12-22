class Solution {
    lengthOfLastWord(s: string): number {
        const words: string[] = s.split(" ");
        let lengthToReturn: number = 0;
        for (let i = 0; i < words.length; i++) {
            if (words[i].length > 0) {
                lengthToReturn = words[i].length;
            }
        }
        return lengthToReturn;
    }
}