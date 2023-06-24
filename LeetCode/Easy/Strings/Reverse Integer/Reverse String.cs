public class ReverseIntegerSln {
    public int Reverse(int x)
    {
        int result = 0;
        while (x != 0)
        {
            try
            {
                result = checked(result * 10 + x % 10);
                x /= 10;
            }
            catch (OverflowException e)
            {
                return 0;
            }
        }

        return result;
    }
}