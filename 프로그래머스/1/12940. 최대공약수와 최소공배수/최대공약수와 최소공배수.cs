public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];

        answer[0] = n >= m ? Gcd(n, m) : Gcd(m, n);
        answer[1] = n * m / answer[0];

        return answer;
    }

    public int Gcd(int a, int b)
    {
        if (b == 0) return a;
        else return Gcd(b, a % b);
    }
}