public class Solution {
    public int SingleNumber(int[] nums) {
        var hashset = new HashSet<int>(nums.Length);
        foreach(var item in nums){
            if(hashset.Contains(item))
            {
                hashset.Remove(item);
            }
            else{   
                hashset.Add(item);
            }
        }

        return hashset.First();
    }
}