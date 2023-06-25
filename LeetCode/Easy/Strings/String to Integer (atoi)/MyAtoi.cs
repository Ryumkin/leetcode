using System.Runtime.InteropServices;

public class MyAtoiSln {
    public int MyAtoi(string s)
    {
        if (s == string.Empty)
        {
            return 0;
        }
        int index = 0;
        bool isNegative = false;
        while (index<s.Length)
        {
            if (s[index] == ' ')
            {
                index++;
                continue;
            }
            else
            {
                break;
            }
        }

        if (index > s.Length - 1)
        {
            return 0;
        }
        if (s[index] == '-')
        {
            isNegative = true;
            index++;
        }else if (s[index] == '+')
        {
            index++;
        }
        
        var result = (long)0;

        while (index<s.Length && s[index]>='0'&&s[index]<='9')
        {
            result = result * 10 + (s[index]) - '0';
            if (isNegative && -result <= int.MinValue)
            {
                return Int32.MinValue;
            }
            
            if (isNegative && -result == -int.MaxValue)
            {
                return -Int32.MaxValue;
            }
            
            if(result >= Int32.MaxValue){
                return int.MaxValue;
            }

            index++;
        }

        return isNegative == true ? (int)-result : (int)result;
    }
}