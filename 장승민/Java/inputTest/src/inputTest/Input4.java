package inputTest;

import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
	
		double PI = 3.14 ; 
		
		Scanner s = new Scanner(System.in);
		System.out.print("반지름을 입력하시오 : ");
		
		double r = s.nextDouble();
		
		double result = PI * r * r;
		System.out.println("원의 넓이는 : "+ result);
		s.close();
		
		
		
		
		
		
		

	}

}
