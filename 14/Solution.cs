public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0){
            return string.Empty;
        }
        if(strs.Length==1){
            return strs[0];
        }
        StringBuilder sb = new StringBuilder();
        try{
        for(int i=0;i<strs[0].Length;i++){
            for(int j=0;j<strs.Length;j++){
                if(strs[j][i]!=strs[0][i]){
                    return sb.ToString();
                }
            }
            sb.Append(strs[0][i]);
        }
        }catch(Exception e){
            return sb.ToString();
        }
        return sb.ToString();
        
    }
}