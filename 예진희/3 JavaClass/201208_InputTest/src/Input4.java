import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		// �ǽ� 5-2�� ����
		// �������� �����ϴ� ������ ����ڰ� �Է��Ͽ� ������ ���
		
		Scanner cal = new Scanner(System.in);
		System.out.print("���� �������� �Է�: ");
		double r = cal.nextDouble();
		final double PI = 3.14;
		
		System.out.println("���� ������ "+(r*r*PI)+"�Դϴ�.");
		
		cal.close();

	}

}
