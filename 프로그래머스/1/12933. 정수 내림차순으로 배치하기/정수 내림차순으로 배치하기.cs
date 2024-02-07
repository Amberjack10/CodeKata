using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] temp = n.ToString().ToCharArray();
        
        Array.Sort(temp);
        Array.Reverse(temp);
        
        string value = new string(temp);
        
        return answer = long.Parse(value);
    }
}