public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int maskingSize = phone_number.Length - 4;
        
        if (maskingSize > 0)
        {
            answer = phone_number.Substring(maskingSize);
            
            for (int i = 0; i < maskingSize; i++) answer = answer.Insert(i, "*");
            return answer;
        }
        return phone_number;
    }
}