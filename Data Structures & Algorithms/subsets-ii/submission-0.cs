public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);    
        List<List<int>> ans = new List<List<int>>();
        List<int> curr = new List<int>();
        helperSubSet(curr, 0, nums, ans);
        return ans;
        
    }
    public void helperSubSet(List<int> curr, int i, int[] nums, List<List<int>> ans)
    {
        if(i==nums.Length)
        {
            // add clone
            ans.Add(new List<int>(curr));
            return;
        }

        // include
        curr.Add(nums[i]);
        helperSubSet(curr, i+1, nums, ans);

        //backtracking step to go to prev place list is mutable so anyone can change
        curr.RemoveAt(curr.Count-1);
        
        int idx = i+1;
        while(idx<nums.Length && nums[idx] == nums[idx-1])
        {
            idx++;
        }
        // Exclude
        helperSubSet(curr, idx, nums, ans);
    }
}
