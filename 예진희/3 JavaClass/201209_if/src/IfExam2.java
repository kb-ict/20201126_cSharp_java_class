import java.util.Scanner;

public class IfExam2 {
	// 2. 2���� ���ڸ� �Է¹޾� ũ��, �۴ٸ� ���ϴ� ���α׷�
	
	public static void main(String[] args) {
		String line = "-----------------------";
		Scanner sc = new Scanner(System.in);
		System.out.println(line);
		System.out.println("  ��� �� ���α׷� v1.0");
		System.out.println(line);
		
		System.out.print(" 1. num1 �Է� => ");
		int num1 = sc.nextInt();
		System.out.print(" 2. num2 �Է� => ");
		int num2 = sc.nextInt();
		
		System.out.println(line);
		if(num1>num2) {
			System.out.println(" num1�� num2���� ũ��");
		}
		else if(num1<num2) {
			System.out.println(" num2�� num1���� ũ��");
		}
		else {
			System.out.println(" num1�� num2�� ����.");
		}
		sc.close();
	}

}
