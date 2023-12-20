function lengthOfLongestSubstring(s: string): number {
    const currentSubstring: Set<string> = new Set();
    let maxLength: number = 0;

    for (let i = 0; i < s.length; i++) {
        const letter = s[i];

        if (currentSubstring.has(letter)) {
            for (const char of currentSubstring) {
                currentSubstring.delete(char);
                if (char === letter) break;
            }
        }

        currentSubstring.add(letter);
        maxLength = Math.max(maxLength, currentSubstring.size);
    }

    return maxLength;
}
