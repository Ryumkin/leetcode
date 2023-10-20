public class FirstBadVersionSln {
    public int FirstBadVersion(int n)
    {
        var left = 1;
        var right = n;
        var result = 0;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            if (IsBadVersion(middle))
            {
                result = middle;
                right = middle - 1;
            }
            else
                left = middle + 1;
        }

        return result;
    }

    public bool IsBadVersion(int middles) => false;
}
