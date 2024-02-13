public class Solution {
    public long solution(int a, int b) {
        
        long answer = 0;
        
        long diff = 0;
        
        if(a <= b) diff = b - a + 1;
        else diff = a - b + 1;
        
        answer = (a + b) * diff / 2;
        
        return answer;
    }
}