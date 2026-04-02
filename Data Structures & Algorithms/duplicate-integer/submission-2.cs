public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        var loadedNums = new HashSet<int>();
        foreach (var num in nums)
        {
            if(loadedNums.Contains(num))
                return true;

            loadedNums.Add(num);
        }

        return false;
    }
}