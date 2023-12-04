public class HouseRobber {
    
    public int Rob(int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;
        foreach (var houseValue in nums)
        {
            (rob1, rob2) = (rob2, Math.Max(rob1 + houseValue, rob2));
        }

        return rob2;
    }
}
