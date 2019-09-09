public class Solution {
    public bool IsValid(string s) {
        if(s=="")
            return true;
        
        if(s.Length%2!=0){
            return false;
        }
        Dictionary<string, int> dicj = new Dictionary<string, int>();
        Dictionary<string, int> dico = new Dictionary<string, int>();
        dicj.Add("(",0);
        dicj.Add(")",0);
        dicj.Add("[",0);
        dicj.Add("]",0);
        dicj.Add("{",0);
        dicj.Add("}",0);
        dico.Add("(",0);
        dico.Add(")",0);
        dico.Add("[",0);
        dico.Add("]",0);
        dico.Add("{",0);
        dico.Add("}",0);
        for(int i=0;i<s.Length;i++){
            if(i%2!=0)
            {
                if(dicj.ContainsKey(s[i].ToString()))
                {
                    dicj[s[i].ToString()] = dicj[s[i].ToString()] + 1;
                }
            }
            else
            {
                if(dico.ContainsKey(s[i].ToString()))
                {
                    dico[s[i].ToString()] = dico[s[i].ToString()] + 1;
                }       
            }
        }
        if(dicj["("]!=dico[")"]||dicj[")"]!=dico["("]||dicj["["]!=dico["]"]||dicj["]"]!=dico["["]||dicj["{"]!=dico["}"]||dicj["}"]!=dico["{"])
         return false;          
        return true;
    }
}