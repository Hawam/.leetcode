/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i%3==0 && i%5==0)
            {
                answer.Add("FizzBuzz");
            }
            else if (i%3==0)
            {
                answer.Add("Fizz");
            }
            else if (i%5==0)
            {
                answer.Add("Buzz");
            }
            else
            {
                answer.Add(i.ToString());
            }
        }
        return answer;
    }
}
// @lc code=end

