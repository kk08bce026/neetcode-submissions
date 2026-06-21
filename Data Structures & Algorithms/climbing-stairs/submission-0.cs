public class Solution {
    int[] memo;
    public int ClimbStairs(int n) {  
        memo = new int[n+1];
        for(int i=0; i<memo.Length; i++)
        {
            memo[i] = -1;
        }
        return helper(n);
    }
    
    public int helper(int n)
    {
        if(n==0){ return 1;}
        if(n<0){ return 0; }

        if(memo[n] != -1)
        {
            return memo[n];
        }

        int one = 1;
        int two = 2;
        int sum = 0;
        if(n-one >=0)
        {
            sum = sum + helper(n-one);
        }
        
        if(n-two >=0)
        {
            sum = sum + helper(n-two);
        }   
        
        memo[n] = sum;
        return memo[n];
    }
}
