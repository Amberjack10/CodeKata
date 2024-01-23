using System;

public class Solution {
    public int solution(int n) {
        
        int answer = 0;

        if (n >= 2 && n <= 1000)
        {
            for (int i = 2; i <= n; i += 2)
            {
                answer += i;
            }
        }
        else if(n > 0 && n < 2)
        {
            return 0;
        }
        else
        {
            Console.WriteLine("invalid value");
            return -1;
        }

        return answer;
    }
}