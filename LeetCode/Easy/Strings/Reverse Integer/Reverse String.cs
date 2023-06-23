public class ReverseIntegerSln {
    public int Reverse(int x)
    {
        long result = 0;
        long number = Math.Abs(x);
        while (number != 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
            if (result > Int32.MaxValue) return 0;
        }

        result = x < 0 ? result * -1 : result;
        return (int)result;
    }
}