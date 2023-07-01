using System.Runtime.InteropServices;

public class StrStrSolution {
    
    //O(M*N)
    public int StrStr1(string haystack, string needle) {
        if (haystack.Length == needle.Length && haystack == needle)
        {
            return 0;
        }
        
        for (int i = 0; i < haystack.Length-needle.Length  + 1; i++)
        {
            int j = 0;
            for (j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    break;
                }
            }

            if (j == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }
    
    //longest prefix suffix portions
    public int[]? LPS(string haystack, string needle) {
        if (haystack.Length < needle.Length)
        {
            return null;
        }

        var lps = new int[needle.Length];
        var previousLps = 0;
        var i = 1;

        while (i < needle.Length)
        {
            if (needle[i] == needle[previousLps])
            {
                lps[i++] = ++previousLps;
            }
            else if (previousLps == 0)
            {
                lps[i++] = 0;
            } else
            {
                previousLps = lps[previousLps - 1];
            }
        }

        return lps;
    }
    
    // O(M + N) Knuth–Morris–Pratt KMP 
    //  https://www.youtube.com/watch?v=JoF0Z7nVSrA
    public int StrStr(string haystack, string needle)
    {

        var lps = LPS(haystack, needle) ?? new int[needle.Length];
        var i = 0;
        var j = 0;

        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            else
            {
                if (j == 0)
                {
                    i++;
                }
                else
                {
                    j = lps[j - 1];
                }
            }

            if (j == needle.Length)
                return i - needle.Length;
        }

        return -1;
    }
}