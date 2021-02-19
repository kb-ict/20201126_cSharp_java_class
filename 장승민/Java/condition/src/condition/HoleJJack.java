package condition;

import java.util.Scanner;

public class HoleJJack {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("숫자를 입력하시오. :");
		int num =sc.nextInt();
		
		if (num % 2 >= 1) 
			{
			System.out.println("입력한 숫자는 홀수입니다.");
			}
		else
			{
			System.out.println("입력한 숫자는 짝수입니다.");
			}

	}

}
