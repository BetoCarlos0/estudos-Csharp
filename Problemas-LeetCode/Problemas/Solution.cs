public class Solution
{
    public int[] TwoSum(int[] nums, int target) { 

        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            for (int j = i+1; j < nums.Length; j++)
                if (temp == nums[j])
                    return new int[] {i, j};
        }
        return nums;
    }
}