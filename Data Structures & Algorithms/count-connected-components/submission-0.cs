public class Solution {
    public int CountComponents(int n, int[][] edges) 
    {
        int[][] B = edges;
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for(int i=0; i<=n; i++)
        {
            graph[i] = new List<int>();
        }
        for(int i=0; i<B.Length; i++)
        {
            int s = B[i][0];
            int e = B[i][1];
            graph[s].Add(e);
            graph[e].Add(s);
        }

        bool[] visited = new bool[n];
        int ans = 0;
        for(int i=0; i<n; i++)
        {
            if(visited[i] == false)
            {
                
                DFS(i, graph, visited);
                ans++;
            }
        }
        return ans;
    }

    public void DFS(int src, Dictionary<int, List<int>> graph, bool[] visited)
    {
        visited[src] = true;
        for(int i=0; i<graph[src].Count; i++)
        {
            int nei = graph[src][i];
            if(visited[nei] == false)
            {
                DFS(nei, graph, visited);
            }
        }
    }
}
