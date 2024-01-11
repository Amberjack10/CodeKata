using System;

public class Solution {
    public int solution(int age) {
        if(age <= 0 || age > 120) throw new Exception("invaild param");
        int answer = 2022 - age + 1;
        return answer;
    }
}