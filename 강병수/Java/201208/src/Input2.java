import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		Scanner c = new Scanner(System.in);
		
		System.out.print("첫번째 정수값 입력: ");
		int num1=c.nextInt();
		System.out.print("두번째 정수값 입력: ");
		int num2=c.nextInt();
		System.out.print("세번째 정수값 입력: ");
		int num3=c.nextInt();
		
		int sum = num1+num2+num3;
		int avr = sum/3;
		
		System.out.println("총합: " + sum);
		System.out.println("평균값: " + avr);
		c.close();

	}

}
