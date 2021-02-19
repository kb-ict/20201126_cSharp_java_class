import java.util.Scanner;

public class IfExam2 {
	// 2. 2개의 숫자를 입력받아 크다, 작다를 비교하는 프로그램
	
	public static void main(String[] args) {
		String line = "-----------------------";
		Scanner sc = new Scanner(System.in);
		System.out.println(line);
		System.out.println("  대소 비교 프로그램 v1.0");
		System.out.println(line);
		
		System.out.print(" 1. num1 입력 => ");
		int num1 = sc.nextInt();
		System.out.print(" 2. num2 입력 => ");
		int num2 = sc.nextInt();
		
		System.out.println(line);
		if(num1>num2) {
			System.out.println(" num1이 num2보다 크다");
		}
		else if(num1<num2) {
			System.out.println(" num2이 num1보다 크다");
		}
		else {
			System.out.println(" num1과 num2는 같다.");
		}
		sc.close();
	}

}
