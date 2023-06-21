public class PlusOneSln {
    public int[] PlusOne(int[] digits)
    {
        int number = 0;
        for (int i = digits.Length - 1; i >=0; i--)
        {
            number = (digits[i] + 1) / 10;
            digits[i] = (digits[i] + 1) % 10;
            if (number == 0)
                return digits;
        }

        if (number > 0)
        {
            var result = new int[digits.Length + 1];
            result[0] = number;
            return result;
        }

        return digits;
    }
}