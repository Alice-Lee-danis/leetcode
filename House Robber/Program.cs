//https://leetcode.com/problems/house-robber/


int[] nums = new int[] { 2, 7, 9, 3, 1,3};
Solution solution = new Solution();

Console.WriteLine(solution.Rob(nums));
public class Solution
{
    public int Rob(int[] nums)
    {
        int sum = 0;


        for (int i = 0; i < nums.Length; i++)
        {

            sum = sum + nums[i];
            i++;


        }
        
        return sum;
    }
}