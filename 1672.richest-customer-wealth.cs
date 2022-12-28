/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
using System.Linq;
public class Solution {
    public int MaximumWealth(int[][] accounts) {

        int Richest = 0;
        int sum = 0;
        foreach (int[] item in accounts)
        {
            sum = item.Sum();
            Richest = sum>Richest? sum:Richest;
        }
        return Richest;
    }
}
// @lc code=end

