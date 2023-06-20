public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashset = new HashSet<int>(nums.Length);
        foreach(var item in nums){
            if(hashset.Contains(item))
            {
                return true;
            }
            else{   
                hashset.Add(item);
            }
        }

        return false;
    }
}