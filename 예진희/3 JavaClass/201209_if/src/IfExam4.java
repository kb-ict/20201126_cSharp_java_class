import java.util.Scanner;

public class IfExam4 {

	public static void main(String[] args) {
		/*
		 * ����1) �Է��� �⵵�� 4�� ������ * �������� 0�̰� 
		 * 100���� ������ 0�� �ƴϾ�� ��.
		 * 
		 * ����2) �Է��� �⵵�� 400���� ������ �������� 0 �̾�� ��.
		 * 
		 * ����3) ����1������ AND �������ڸ� ���.
		 * 
		 * ����4) ����1�� ����2�� OR �������ڸ� ���.
		 * --------------------------------------------------
		 * 4�� ������ �������� 100���� ������ ��������,
		 * 400���� ������ �������� �����Դϴ�.
		 * 2000�� ���� ��� 400���� ������ �������� ������ �����Դϴ�.
		 * --------------------------------------------------
		 */
		Scanner sc = new Scanner(System.in);
		String line = "-----------------------------";
		System.out.println(line);
		System.out.println("  �⵵�� ���� ���� ���α׷� v1.0");
		System.out.println(line);
		System.out.print(" �⵵ �Է� => ");
		int year = sc.nextInt();
		System.out.println(line);
		
		if (year%4==0 && year%100!=0 || year%400==0) {
			System.out.println(year+"���� �����Դϴ�.");
		}
		else {
			System.out.println(year+"���� ������ �ƴմϴ�.");
		}
		sc.close();
	}

}
