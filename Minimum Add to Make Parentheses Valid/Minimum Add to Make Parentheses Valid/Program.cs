public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        int openNeeded = 0;
        int closeNeeded = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                closeNeeded++;
            }
            else if (c == ')')
            {
                if (closeNeeded > 0)
                {
                    closeNeeded--;
                }
                else
                {
                    openNeeded++;
                }
            }
        }

        return openNeeded + closeNeeded;
    }
}