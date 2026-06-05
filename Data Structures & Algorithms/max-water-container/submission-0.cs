public class Solution {
    public int MaxArea(int[] heights) 
    {
        int s = 0;
        int n = heights.Length;
        int e = n-1;
        int maxArea = int.MinValue;

        while(s<e)
        {
            int height = Math.Min(heights[s], heights[e]);
            int width = e-s;
            int area = height * width;
            maxArea = Math.Max(maxArea, area);

            if(heights[s] < heights[e])
            {
                s++;
            }
            else
            {
                e--;
            }
        }
        return maxArea;
    }
}
