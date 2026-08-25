namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/smallest-missing-multiple-of-k
public class SmallestMissingMultipleOfK {
    public int MissingMultiple(int[] nums, int k) {
        var set = new HashSet<int>(nums);

        for (int i = k; ;i += k){
            if (!set.Contains(i)){
                return i;
            }
        }
    }
}