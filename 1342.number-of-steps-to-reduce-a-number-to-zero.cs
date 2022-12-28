/*
 * @lc app=leetcode id=1342 lang=csharp
 *
 * [1342] Number of Steps to Reduce a Number to Zero
 */

// @lc code=start
public class Solution {
    public int NumberOfSteps(int num) {
        
        return CalculateSteps(num);
    }

    int CalculateSteps(int num, int step=0)
    {
        if (num == 0)
            return step;
        if (num%2==0)
            num = num/2;
        else 
            num--;
        step++;

        return CalculateSteps(num, step);
    }
}
// @lc code=end

