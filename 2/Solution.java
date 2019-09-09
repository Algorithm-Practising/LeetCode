/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
import java.math.*;
import java.util.*;
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        List<Integer> list = new ArrayList<Integer>();
        list.add(l1.val);
        List<Integer> list2 = new ArrayList<Integer>();
        list2.add(l2.val);
        while(l1.next!=null){
            l1 = l1.next;
            list.add(l1.val);
        }
        while(l2.next!=null){
            l2 = l2.next;
            list2.add(l2.val);
        }
        Integer[] arr = (Integer [])list.toArray(new Integer[0]);
        Integer[] arr2 = (Integer [])list2.toArray(new Integer[0]);
        //list.toArray(arr);
        //list2.toArray(arr2);
        BigInteger num1 = new BigInteger("0");
        BigInteger num2 = new BigInteger("0");
        BigInteger bi = null;
        BigInteger seed = new BigInteger("1");
        for(int i=0;i<arr.length;i++){
            BigInteger k = seed.multiply(new BigInteger(arr[i]+""));
            bi = new BigInteger(k+""); 
            num1 = num1.add(bi);
            seed = seed.multiply(new BigInteger("10"));
        }
        seed = new BigInteger("1");
        for(int i=0;i<arr2.length;i++){
            BigInteger k = seed.multiply(new BigInteger(arr2[i]+""));
            bi = new BigInteger(k+"");
            num2 = num2.add(bi);
            seed = seed.multiply(new BigInteger("10"));
        }
        num1 = num1.add(num2);
        BigInteger num = num1;
        BigInteger flag = new BigInteger(10+"");
        
        num1 = num1.remainder(new BigInteger(flag+""));
        ListNode ln = new ListNode(num1.intValue());
        ListNode lnresult = ln;
        ListNode lnn = null;
        while(flag.compareTo(num)!=1){
            num1 = num.divide(new BigInteger(flag+""));//  /
            flag = flag.multiply(new BigInteger(10+""));// *
            num1 = num1.remainder(new BigInteger(10+""));// %
            lnn = new ListNode(num1.intValue());
            ln.next = lnn;
            ln = ln.next;
        }
        return lnresult;
    }
}