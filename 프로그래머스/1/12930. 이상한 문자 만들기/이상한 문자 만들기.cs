using System.Text;

public class Solution
{
    public string solution(string s)
    {
        StringBuilder answer = new StringBuilder();
        int index = 0;

        for (int i = 0; i < s.Length; i++)
        {
            answer.Append(index % 2 == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]));
            index = s[i] == ' ' ? 0 : index += 1;
        }
        return answer.ToString();
    }
}