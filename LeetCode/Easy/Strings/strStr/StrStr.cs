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
    public int LPS(string haystack, string needle) {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        
    }
    
    // O(M + N) Knuth–Morris–Pratt KMP 
    //  https://www.youtube.com/watch?v=JoF0Z7nVSrA
    public int StrStr(string haystack, string needle) {

        if (needle == string.Empty)
        {
            return 0;
        }
        
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        var lps = new int[needle.Length];
        
        var previousLPS = 0, i = 0, 
    }
}