public class Solution {
    public List<List<int>> Permute(int[] nums) 
    {
        List<List<int>> ans = new List<List<int>>();
        
        helper(0, nums, ans);
        return ans;
    }

    public void helper(int i, int[] nums, List<List<int>> ans)
    {
        if(i == nums.Length)
        {
            ans.Add(new List<int>(nums));
            return;
        }

        for(int j=i; j<nums.Length; j++)
        {
            swap(nums, i, j);

            helper(i+1, nums, ans);
            swap(nums, i, j);
        }
    }

    public void swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
