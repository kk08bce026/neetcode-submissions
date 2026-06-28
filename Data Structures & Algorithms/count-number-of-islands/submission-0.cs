public class Solution {
    public int NumIslands(char[][] grid) 
    {
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        List<List<bool>> visited = new List<List<bool>>();
        for(int i=0; i<rowCount; i++)
        {
            visited.Add(new List<bool>(new bool[colCount]));
        } 
        
        int islands = 0;
        
        for(int i=0; i<rowCount; i++)
        {
            for(int j=0; j<colCount; j++)
            {
                if(grid[i][j] == '1' && visited[i][j] == false)
                {
                    DFS(i, j, grid, visited);
                    islands++;
                }
            }
        }
        return islands;

    }

    public bool IsValid(int row, int col, int rowCount, int colCount)
    {
        return (row>=0 && row<rowCount && col>=0 && col<colCount);
    }

    public void DFS(int row, int col, char[][] grid, List<List<bool>> visited)
    {
        visited[row][col] = true;
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        int[] dx =new int[]{-1, 1, 0, 0};
        int[] dy =new int[]{0, 0, -1, 1};
        
        for(int i=0; i<4;i++)
        {
            int nr = row + dx[i];
            int nc = col + dy[i];
            if(IsValid(nr, nc, rowCount, colCount) && grid[nr][nc] == '1' && visited[nr][nc] == false)
            {
                DFS(nr, nc, grid, visited);
            }
        }
    }
}
