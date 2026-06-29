public class Solution {
    public bool CanJump(int[] nums) 
    {
        int n = nums.Length;
        int[] dp = new int[n];
        dp[0] = nums[0];
        
        for(int i=1; i<n; i++)
        {
            dp[i] = Math.Max(dp[i-1], i+nums[i]);
        }

        int idx = 0;
        while(idx < n-1)
        {
            if(idx == dp[idx])
            {
                return false;
            }
            idx = dp[idx];
        }
        return true;
    }
}
