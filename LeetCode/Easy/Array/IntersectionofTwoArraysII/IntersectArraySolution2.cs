public class IntersectArraySolution2 {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var result = new List<int>(Math.Max(nums1.Length, nums2.Length));

        var dict = nums1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        foreach (var item in nums2)
        {
            if (!dict.TryGetValue(item, out var count) || count <= 0)
            {
                continue;
            }
            result.Add(item);
            dict[item]--;
        }

        return result.ToArray();
    }
}