public class Solution {
    Dictionary<string, int> memo;
    public int Change(int amount, int[] coins) 
    {
        memo = new Dictionary<string, int>();
        Array.Sort(coins);
        return helper(amount, 0, coins);
    }
    public int helper(int amount, int index, int[] coins)
    {
        
        if(amount == 0){ return 1;}
        if(amount < 0){ return 0;}

        string key = amount+","+index;
        if(memo.ContainsKey(key))
        {
            return memo[key];
        }

        int sum = 0;
        for(int i = index; i<coins.Length; i++)
        {
            if(amount-coins[i] >= 0)
            {
                sum = sum + helper(amount-coins[i], i, coins); 
            }
        } 

        memo[key] = sum;
        return memo[key];
    }
}
