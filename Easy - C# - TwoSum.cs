public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = new int[2];
        for (int i = 0; i < (nums.Length/2)+1; i++)
        {
            if (nums.Contains(target - nums[i]))
            {
                output[0] = i;
                output[1] = Array.IndexOf(nums, (target - nums[i]));
                continue;
            }
        }
        return output;
    }
}
