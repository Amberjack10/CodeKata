using System;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;

        for(int i = left; i <= right; i++)
        {
            if (MathF.Sqrt(i) == (int)MathF.Sqrt(i)) answer -= i;
            else answer += i;
        }

        return answer;
    }
}