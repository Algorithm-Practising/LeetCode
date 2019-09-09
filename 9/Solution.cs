public class Solution {
    public bool IsPalindrome(int x) {
        String str = Convert.ToString(x);
        for(int i=0;i<str.Length/2;i++){
            if(str[i]!=str[str.Length-i-1]){
                return false;
            }
        }
        return true;
    }
}