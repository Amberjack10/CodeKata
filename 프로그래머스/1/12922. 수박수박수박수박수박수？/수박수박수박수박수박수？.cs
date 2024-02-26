using System.Text;

public class Solution
{
    public string solution(int n)
    {
        StringBuilder sb = new StringBuilder();
        bool flag = true;

        for (int i = 0; i < n; i++)
        {
            if (flag) sb.Append("수");
            else sb.Append("박");

            flag = !flag;
        }

        return sb.ToString();
    }
}