import java.util.Scanner;

public class IfExam1 {

	public static void main(String[] args) {
		// 1. 홀짝 판단 프로그램
		Scanner sc = new Scanner(System.in);
		String line = "-----------------------";
		
		System.out.println(line);
		System.out.println("  홀짝 판단 프로그램 v1.0");
		System.out.println(line);
		
		System.out.print("숫자 입력 => ");
		int num = sc.nextInt();
		
		if (num%2==0) {
			System.out.println("1) 입력한 숫자는 짝수입니다.");
		}
		else {
			System.out.println("2) 입력한 숫자는 홀수입니다.");
		}
		

		sc.close();
	}

}
