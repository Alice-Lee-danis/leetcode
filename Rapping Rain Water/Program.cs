//https://leetcode.com/problems/trapping-rain-water/

int[] height = new int[] { 0, 0, 5, 3, 4, 2, 4, 6, 5, 4, 3, 7, 2, 3, 2 };

Solution solution = new Solution();

Console.WriteLine(solution.Trap(height));

public class Solution
{
    public int Trap(int[] height)
    {
        int weight = 0;
        int height_plus = 0;
        int max = 0;
        int start = 0;
        bool y = true;

        int sum = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (y == true)
            {
                if (height[i] > 0)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        if (height[i] > height[j])
                        {
                            if (height[i] > height[max])
                            {
                                if (j < height.Length - 1)
                                {
                                    max = j;
                                    weight = weight + 1;
                                    height_plus = height_plus + height[j];
                                    y = true;
                                }
                                else
                                {
                                    height_plus = 0;
                                    weight = 0;
                                    y = false;
                                }
                            }
                        }
                        else
                        {
                            sum = sum + (weight * height[i]) - height_plus;
                            height_plus = 0;
                            weight = 0;
                            i = j - 1;
                            max = 0;
                            start = i + 1;
                            break;
                        }
                    }
                }
            }
            else
            {
                break;
            }
        }
        for (int i = start + 1; i <= max; i++)
        {
            if (i < max)
            {
                weight = weight + 1;
                height_plus = height_plus + height[i];
            }
            else
            {
                sum = sum + (weight * height[i]) - height_plus;
            }
        }
        return sum;
    }
}
