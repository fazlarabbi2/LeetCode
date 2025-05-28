public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int differences = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % m != 0)
            {
                differences += i;
            }
            else
            {
                differences -= i;
            }
        }

        return differences;
    }
}
