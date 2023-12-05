public class ShuffleSolution
{
    private readonly int[] _nums;
    
    public ShuffleSolution(int[] nums)
    {
        _nums = nums;
    }
    
    public int[] Reset()
    {
        return _nums;
    }
    
    public int[] Shuffle()
    {
        var random = new Random();
        var result = new int[_nums.Length].AsSpan();
        _nums.CopyTo(result);
        for (int i = 0; i < result.Length; i++)
        {
            var index = random.Next(0, result.Length);
            (result[i], result[index]) = (result[index], result[i]);
        }

        return result.ToArray();
    }
}
