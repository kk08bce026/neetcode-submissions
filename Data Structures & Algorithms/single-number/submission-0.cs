public class Solution {
    public int SingleNumber(int[] nums) 
    {
      int val = nums[0];
      for(int i=1; i<nums.Length; i++)
      {
        val = val ^ nums[i];
      }
      return val;   
    }
}
