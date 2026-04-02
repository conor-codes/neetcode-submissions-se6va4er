public class Solution {
    public bool hasDuplicate(int[] nums) {
        var loadedNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(loadedNums.Contains(nums[i])) 
                return true;

            loadedNums.Add(nums[i]);
        }

        return false;
    }
}