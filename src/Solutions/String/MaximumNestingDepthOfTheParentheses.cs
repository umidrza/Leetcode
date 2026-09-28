namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
public class MaximumNestingDepthOfTheParentheses {
    public int MaxDepth(string s) {
        int curr = 0, max = 0;
        
        foreach(char c in s){
            if (c == '('){
                curr++;
                max = Math.Max(max, curr);
            }
            else if (c == ')'){
                curr--;
            }
        }

        return max;
    }
}