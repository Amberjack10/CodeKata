using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = arr.Where(x => (x % divisor) == 0).OrderBy(x => x).ToArray();

        if (answer.Count() == 0)
        {
            answer = new int[1];
            answer[0] = -1;
        }

        return answer;
    }
}