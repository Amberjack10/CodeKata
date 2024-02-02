public class Solution {
    public int[] solution(long n) {
        int[] temp = new int[11];
        int i = 0;
        
        for(i = 0; n > 0; i++, n /= 10){
            temp[i] = (int) (n % 10);
        }
        
        int[] answer = new int[i];
        
        for(int j = 0; j < i; j++){
            answer[j] = temp[j];
        }
        
        return answer;
    }
}