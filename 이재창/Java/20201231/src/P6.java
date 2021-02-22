import java.util.Scanner;

class P6 {
     public static void main(String[] args) {
    	 Scanner s = new Scanner(System.in);
    	 int n = s.nextInt();
    	 int m = s.nextInt();
    	 System.out.println(sum(n, m));
     }
     
     public static int sum(int n, int m) {
    	 int hab = 0;
    	 for (int i = 1; i <= n; i++) {
    		 if (i % m != 0) {
    			 hab += i;
    		 }
    	 }
    	 return hab;
     }
}
