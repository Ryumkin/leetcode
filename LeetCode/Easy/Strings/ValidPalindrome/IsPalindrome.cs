using System.Runtime.InteropServices;

public class IsPalindromeSln {
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length-1;
        while (left<=right)
        {
            var l = Char.ToLower(s[left]);
            var r = Char.ToLower(s[right]);
            if (!Char.IsNumber(l) && (l < 'a' || l > 'z'))
            {
                left++; 
                continue;
            }
            
            if (!Char.IsNumber(r) && (r < 'a' || r > 'z'))
            {
                right--; 
                continue;
            }

            if (r != l)
            {
                return false;
            }

            right--;
            left++;
        }

        return true;
    }
}