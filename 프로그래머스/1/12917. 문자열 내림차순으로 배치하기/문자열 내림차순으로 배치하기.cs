using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        char[] c = s.ToCharArray();

        Array.Sort(c);
        Array.Reverse(c);

        answer = new string(c);

        return answer;
    }
}