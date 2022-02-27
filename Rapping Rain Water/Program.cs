//https://leetcode.com/problems/trapping-rain-water/

int[] height = new int[] { 0, 0, 5, 3, 4, 5, 2, 6, 5, 4, 3, 6, 2, 3, 2 };
//7,0,4,2,5,0,6,4,0,5
Solution solution = new Solution();
Console.WriteLine(solution.Trap(height));


public class Solution
{
    public int Trap(int[] height)
    {
        int heightt = 0;
        int width = 0;
        int sum = 0;
        bool y = true;

        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > 0)
            {
                if (y == true)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        if (height[j] < height[i])
                        {
                            width++;
                            heightt = heightt + height[j];
                            if (j == height.Length - 1)
                            {
                                heightt = 0;
                                width = 0;
                                y = false;
                                i = i - 1;
                            }
                        }
                        else
                        {
                            sum = sum + (width * height[i]) - heightt;
                            heightt = 0;
                            width = 0;
                            i = j;
                        }
                    }
                }
                else
                {
                    heightt = 0;
                    width = 0;
                    int maxx = 0;
                    int chislo = 0;
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        if (chislo < height[j])
                        {
                            chislo = height[j];
                            maxx = j;

                        }

                    }
                    for (int j = i + 1; j < maxx + 1; j++)

                    {
                        if (j < maxx)
                        {
                            width++;
                            heightt = heightt + height[j];
                        }
                        else
                        {
                            sum = sum + (width * height[j]) - heightt;
                            heightt = 0;
                            width = 0;
                            i = j - 1;
                        }
                    }
                }
            }
        }

        return sum;
    }
}
