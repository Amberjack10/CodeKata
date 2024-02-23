public class Solution {
    public string solution(string s) {
        string answer = "";
        int halfLength = s.Length / 2;
        
        if(s.Length % 2 == 0)
            answer = s.Substring(halfLength - 1, 2);
        else
            answer = s[halfLength].ToString();
        
        return answer;
    }
}