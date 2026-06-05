public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] ans = new int[2];
        for(int i=0; i<nums.Length; i++)
        {
            int y = target-nums[i];
            if(dict.ContainsKey(y))
            {
                ans[0] = dict[y];
                ans[1] = i;
                break;
            }

            dict.Add(nums[i], i);
        }
        return ans;

    }
}
