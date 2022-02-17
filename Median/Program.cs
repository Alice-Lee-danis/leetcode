//https://leetcode.com/problems/median-of-two-sorted-arrays

int[] mas1 = new int[] { 1, 4, 2 };
int[] mas2 = new int[] { 3, 2 };
Median.GetMedian(mas1, mas2);


public class Median
{
    public static void GetMedian(int[] mas1, int[] mas2)
    {

        if (((mas1.Length + mas2.Length) % 2) == 0)
        {
            double one = mas1[mas1.Length - 1];
            double two = mas2[0];
            double result = (one + two) / 2;
            Console.WriteLine(result);
        }

        else
        {
            if ((mas1.Length % 2) != 0)
            {
                Console.WriteLine(mas1[mas1.Length - 1]);
            }
            else
            {
                Console.WriteLine(mas2[0]);
            }
        }

    }
}

