
class P5 {
     public static void main(String[] args) {
    	 System.out.println(sum());
     }
     
     public static int sum() {
    	 int hab = 0;
    	 for (int i = 1; i <= 100; i++) {
    		 if (i % 2 == 1) {
    			 hab += i;
    		 }
    	 }
    	 return hab;
     }
}
