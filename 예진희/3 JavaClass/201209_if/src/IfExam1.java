import java.util.Scanner;

public class IfExam1 {

	public static void main(String[] args) {
		// 1. Ȧ¦ �Ǵ� ���α׷�
		Scanner sc = new Scanner(System.in);
		String line = "-----------------------";
		
		System.out.println(line);
		System.out.println("  Ȧ¦ �Ǵ� ���α׷� v1.0");
		System.out.println(line);
		
		System.out.print("���� �Է� => ");
		int num = sc.nextInt();
		
		if (num%2==0) {
			System.out.println("1) �Է��� ���ڴ� ¦���Դϴ�.");
		}
		else {
			System.out.println("2) �Է��� ���ڴ� Ȧ���Դϴ�.");
		}
		

		sc.close();
	}

}
