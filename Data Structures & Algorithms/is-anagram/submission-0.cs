public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char,int>();
        if (s.Length !=  t.Length)
            return false;
          
        foreach (char letter in s)
        {
            if(dict.ContainsKey(letter))
            {
               dict[letter] = dict[letter] + 1;
               continue;
            }
            dict.Add(letter, 1);
        }

        foreach(char c in t)
        {
            if(dict.ContainsKey(c))
            {
               dict[c] = dict[c] - 1;
               if(dict[c] < 0)
                 return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
