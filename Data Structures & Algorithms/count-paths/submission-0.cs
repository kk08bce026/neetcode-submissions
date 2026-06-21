public class Solution {
    public Dictionary<string, int> memo = new Dictionary<string, int>();
    public int UniquePaths(int m, int n) 
    {
        int s_row = 0;
        int s_col = 0;
        int d_row = m-1;
        int d_col = n-1;
        return helper(s_row, s_col, d_row, d_col);
        
    }

    public int helper(int row, int col, int Drow, int Dcol)
    {
        if(row == Drow && col==Dcol)
        {
            return 1;
        }
        if(row>Drow){ return 0;}
        if(col>Dcol){ return 0;}
        
        string key = row +","+col;
        if(memo.ContainsKey(key))
        {
            return memo[key];
        }
        // call for row
        int fromRow = helper(row+1, col, Drow, Dcol);
        int fromCol = helper(row, col+1, Drow, Dcol);
        memo[key] = fromRow + fromCol;
        return memo[key];
    }
}
