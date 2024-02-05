public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        if(int.TryParse(s, out answer)){
            return answer;
        }
        
        // invalid Value
        return -111111;
    }
}