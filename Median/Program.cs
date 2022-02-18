//https://leetcode.com/problems/median-of-two-sorted-arrays

int[] mas1 = new int[] { 1, 2,2 ,4};
int[] mas2 = new int[] { 1,3,6,8,3 };
Median median = new Median();
Console.WriteLine(median.GetMedian(mas1, mas2));


public class Median
{

    public string GetMedian(int[] l1, int[] l2)
    {
        string median;

        int[] add = add_cycle(l1, l2);

        if (add.Length % 2 > 0)
        {
            median = add[((add.Length + 1) / 2)-1] + " ";
        }
        else
        {
           
            median = (double)((add[(add.Length / 2) - 1] + (add[add.Length / 2]))) / 2 + " ";
        }



        return median;
    }


    public int[] add_cycle(int[] secondary, int[] secondary2)
    {
        int[] arr = new int[secondary.Length + secondary2.Length];
        for (int i = 0; i < secondary.Length; i++)
        {
            arr[i] = secondary[i];
        }
        for (int i = 0; i < secondary2.Length; i++)
        {
            arr[secondary.Length + i] = secondary2[i];
        }

        return sortinig(arr);
    }

    public int[] sortinig(int[] sort)
    {
        for (int i = 0; i < sort.Length; i++)
        {
            for (int j = i+1; j < sort.Length; j++)
            {

                if (sort[i] > sort[j])
                {
                    int one = sort[i];
                    int two = sort[j];


                    sort[i] = two;
                    sort[j] = one;

                }
            }
        }


        return sort;
    }
}

