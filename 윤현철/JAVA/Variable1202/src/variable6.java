import java.util.Scanner;

public class variable6 {

	public static void main(String[] args) {
	
		Scanner sc = new Scanner(System.in);
		System.out.println("숫자 하나를 입력하시오 : ");
		int num1 = sc.nextInt();
		num1 = num1 % 2;
		String a = (num1 > 0) ? "홀수" : "짝수";
		System.out.println(a);
		sc.close();
		}
		
	}

