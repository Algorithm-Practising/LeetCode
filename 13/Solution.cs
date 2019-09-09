public class Solution {
    public int RomanToInt(string s) {
        int m=0;
        StringBuilder sb = new StringBuilder(s);
        if(s.Contains("IV")){
            sb = sb.Replace("IV","");
            m+=4;
        }
        if(s.Contains("IX")){
            sb = sb.Replace("IX","");
            m+=9;
        }
        if(s.Contains("XL")){
            sb = sb.Replace("XL","");
            m+=40;
        }
        if(s.Contains("XC")){
            sb = sb.Replace("XC","");
            m+=90;
        }
        if(s.Contains("CD")){
           sb = sb.Replace("CD","");
            m+=400;
        }
        if(s.Contains("CM")){
            sb = sb.Replace("CM","");
            m+=900;
        }
        s = sb.ToString();
        m+=s.Count(p=>p=='M')*1000;
        m+=s.Count(p=>p=='D')*500;
        m+=s.Count(p=>p=='C')*100;
        m+=s.Count(p=>p=='L')*50;
        m+=s.Count(p=>p=='X')*10;
        m+=s.Count(p=>p=='V')*5;
        m+=s.Count(p=>p=='I');
        
        return m;
    }
}