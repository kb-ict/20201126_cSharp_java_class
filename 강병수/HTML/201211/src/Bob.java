
public class Bob{

	public static void main(String[] args) {
		 
		 double Lunch;
		 
		 Lunch = (double) (Math.random());
		 if (0 <= Lunch && Lunch < 0.25) {
			 System.out.println("기사식당");
		 }
			 else if (0.25<= Lunch && Lunch < 0.5) {
				 System.out.println("편의점");
			 }
				 else if(0.5<= Lunch && Lunch < 0.75) {
					 System.out.println("홍콩반점");
				 }
					 else {
						 System.out.println("학교식당");
					 }
	 }
	}
