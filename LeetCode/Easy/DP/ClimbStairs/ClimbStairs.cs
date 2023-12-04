public class ClimbStairsSln {
    public int ClimbStairs(int n)
    {
        int previous = 1, previous2 = 1; //-1,-2

        for (int i = 2; i <= n; i++)
        {
            var temp = previous + previous2;
            previous2 = previous;
            previous = temp;
        }

        return previous;
    }
}
