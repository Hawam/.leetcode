/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        else 
        {
            string s = Reverse(x.ToString());
            long r = long.Parse(s);
            if(x==r)
            {
                return true;
            }
            else return false;
        }
    }

    public string Reverse( string s )
    {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
    }
}
// @lc code=end

