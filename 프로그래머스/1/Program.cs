namespace Programmers29
{
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int[] arr)
            {
                List<int> answer = arr.ToList();
                if (answer.Count == 1)
                {
                    answer[0] = -1;
                }
                else
                {
                    int min = answer[0];
                    int index = 0;

                    for (int i = 0; i < answer.Count; i++)
                    {
                        if (answer[i] <= min)
                        {
                            min = answer[i];
                            index = i;
                        }
                    }

                    answer.RemoveAt(index);
                }
                
                return answer.ToArray();
            }
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            foreach(int i in solution.solution([4, 3, 2, 1]))
            Console.WriteLine($"{i}");
        }
    }
}
