using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;

        for(int i = 0; i < t.Length - p.Length + 1; ++i){
            long a = long.Parse(t.Substring(i, p.Length));
            long b = long.Parse(p);
            
            if(a <= b) answer++;
        }

        return answer;
    }
}