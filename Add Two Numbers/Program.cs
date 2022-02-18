//https://leetcode.com/problems/add-two-numbers/

int[] one = new int[] { 1,2,3 };
int[] two = new int[] {2,3,4};
Solution solution = new Solution();
Console.WriteLine(solution.AddTwoNumbers(one, two));




public class Solution
{

    public string AddTwoNumbers(int[] l1, int[] l2)
    {
        int n1 = condition(l1);
        int n2 = condition(l2);
        int n3 = n1 + n2;
        string number1 = n3.ToString();
        string number2 = "";
        for (int i = number1.Length - 1; i >= 0; i--)
        {
            number2 = number2 + number1[i];
        }
        return number2;
    }

    public int condition(int[] l)
    {
        string tt = "";
        for (int i = l.Length - 1; i >= 0; i--)
        {

            tt = tt + l[i];

        }

        int d = Convert.ToInt32(tt);
        return d;
    }

}

