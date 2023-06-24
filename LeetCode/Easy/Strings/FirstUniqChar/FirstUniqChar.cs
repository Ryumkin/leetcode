public class FirstUniqCharSln {
    public int FirstUniqChar1(string s)
    {
        var hash = new Dictionary<int, int>();
        for (int i = 0; i < s.Length; i++)
        {
            var t= hash.GetValueOrDefault(s[i], 0);
            hash[s[i]] = t+1;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (hash[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
    
    public int FirstUniqChar2(string s)
    {
        var arr = new nint[Char.MaxValue];
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i]]++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (arr[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}