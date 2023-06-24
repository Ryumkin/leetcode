using System.Runtime.InteropServices;

public class IsAnagramSln {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<int, int>();
        for (int i = 0; i < s.Length; i++)
        {
            var count = dict.GetValueOrDefault(s[i], 0);
            dict[s[i]] = count + 1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            var count = dict.GetValueOrDefault(t[i], 0);
            dict[t[i]] =  count - 1;
        }

        return dict.Values.All(x => x == 0);
    }
}