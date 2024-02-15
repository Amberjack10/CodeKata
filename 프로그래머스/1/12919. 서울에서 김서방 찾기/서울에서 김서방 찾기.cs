using System;

public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int index = 0;
        
        index = Array.FindIndex(seoul, s => s.Equals("Kim"));
        
        answer = $"김서방은 {index}에 있다";
        
        return answer;
    }
}