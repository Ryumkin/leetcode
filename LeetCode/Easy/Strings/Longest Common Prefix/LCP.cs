public class LongestCommonPrefixSln {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
            return strs[0];
        var commonPrefix = "";
        var maxLength = strs[0].Length;
        int index = 0;
        while (index < maxLength)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < maxLength)
                {
                    maxLength = strs[i].Length;
                }

                if (index >= maxLength)
                {
                    return commonPrefix;
                }
                if (strs[i][index] != strs[0][index])
                {
                    return commonPrefix;
                }
            }

            commonPrefix = strs[0].Substring(0, ++index);
        }

        return commonPrefix;
    }
}