public class Program {
    public static void Main()
    {
        Solution solution = new Solution();

        int[] nums = {3,2,4};

        int[] result = solution.TwoSum(nums, 6);

        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }
}