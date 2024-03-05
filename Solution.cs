public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        List<char> sequenceList = new List<char>();
        HashSet<char> sequenceSet = new HashSet<char>();
        foreach(var sequence in s){            
            
            while(sequenceList.Count > 0 && sequenceSet.Contains(sequence)){
                char mostLeft = sequenceList[0];
                sequenceList.RemoveAt(0);   
                sequenceSet.Remove(mostLeft);
                         
            }

            sequenceList.Add(sequence);
            sequenceSet.Add(sequence);
            maxLength = Math.Max(sequenceList.Count, maxLength);

        }

        return maxLength;
    }
}
