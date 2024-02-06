namespace Programmers19
{
    internal class Program
    {
        public class Solution
        {
            public long solution(long n)
            {
                long answer = 0;

                answer = (long)Math.Sqrt(n);

                if(answer * answer == n)
                {
                    return answer;
                }

                return -1;
            }
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine($"{solution.solution(49000000000000)}");
        }
    }
}
