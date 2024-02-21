namespace Programmers28
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int[] numbers)
            {
                int answer = 45;

                foreach (int i in numbers)
                {
                    answer -= i;
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution([1,2,3,4,6,7,8,0]));
        }
    }
}
