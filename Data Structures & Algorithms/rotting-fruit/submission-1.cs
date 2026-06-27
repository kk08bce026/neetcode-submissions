public class Solution {

    public class cell
    {
        public int time;
        public int row;
        public int col;
        public cell(int t, int r, int c)
        {
            this.time = t;
            this.row = r;
            this.col = c;
        }
    }

    public int OrangesRotting(int[][] grid) 
    {
        int rotten = 2;
        int fresh = 1;
        int empty = 0;
        int freshCount = 0;
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        Queue<cell> Q = new Queue<cell>();
        for(int i=0; i<rowCount; i++)
        {
            for(int j=0; j<colCount; j++)
            {
                if(grid[i][j] == rotten)
                {
                    Q.Enqueue(new cell(0, i, j));
                }
                if(grid[i][j] == fresh)
                {
                    freshCount++;
                }
            }
        }

        int minTime=0;
        while(Q.Count>0)
        {
            cell c = Q.Dequeue();
            int ftime = c.time;
            int frow = c.row;
            int fcol = c.col;
            minTime = ftime;

            int[] dx = new int[]{-1, 1, 0, 0};
            int[] dy = new int[]{0, 0, -1, 1};

            for(int i=0; i<4; i++)
            {
                int nr = frow+dx[i];
                int nc = fcol+dy[i];
                if(IsValid(nr, nc, rowCount, colCount) && grid[nr][nc]== fresh)
                {
                    grid[nr][nc]= rotten;
                    Q.Enqueue(new cell(ftime+1, nr, nc));
                    freshCount--;
                }
            }
        }
        if(freshCount == 0)
        {
            return minTime;
        }
        return -1;

        
    }

    public bool IsValid(int row, int col, int rowCount, int colCount)
    {
        if(row>=0 && row<rowCount && col>=0 && col<colCount)
        {
            return true;
        }
        return false;
    }
}
