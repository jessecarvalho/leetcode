<?php
class Solution {
    function isPalindrome($x) {
        $digits = str_split((string)$x);
        $length = count($digits);
        for ($i = 0; $i < $length / 2; $i++) {
            if ($digits[$i] !== $digits[$length - 1 - $i]) {
                return false;
            }
        }
        return true;
    }
}
