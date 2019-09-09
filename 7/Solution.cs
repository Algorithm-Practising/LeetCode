public class Solution {
    public int Reverse(int x) {
        long t = x%10;
        while((x/=10)!=0){
                t *= 10;
                t += x%10;
        }
        if(t>2147483647||t<-2147483648)
            return 0;
        return int.Parse(t.ToString());
    }
}