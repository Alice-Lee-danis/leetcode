//https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/

List<int> one = new List<int> { 1, 2, 3,2,4,7,7,5,6,5,10,12,11,12};

Solution solution = new Solution();

for (int i = 0;i< solution.DeleteDuplicate(one).Count; i++)
{
    Console.WriteLine(solution.DeleteDuplicate(one)[i]);
}


public class Solution
{
 
    public List<int> DeleteDuplicate(List<int> list_duplicate)
    {
        for (int i = 0; i < list_duplicate.Count; i++)
        {
            int d;
            for (int j = i + 1; j < list_duplicate.Count; j++)
            {
                if (list_duplicate[i] == list_duplicate[j])
                {
                    d = list_duplicate[i];

                    for (int k = 0; k < list_duplicate.Count; k++)
                    {
                        if (list_duplicate[k] == d)
                        {
                            list_duplicate.RemoveAt(k);
                            k = k - 1;

                        }
                    }
                    j = j - 1;

                }
            }
        }

        return list_duplicate;
    }


    public List<int> Sorting(List<int> sorted_list)
    {
        for (int i = 0; i < sorted_list.Count; i++)
        {
            for (int j = i + 1; j < sorted_list.Count; j++)
            {
                if (sorted_list[i] > sorted_list[j])
                {
                    int onee = sorted_list[i];
                    int twoo = sorted_list[j];

                    sorted_list[i] = twoo;
                    sorted_list[j] = onee;


                }
            }
        }
        return sorted_list;
    }
}

    
    



