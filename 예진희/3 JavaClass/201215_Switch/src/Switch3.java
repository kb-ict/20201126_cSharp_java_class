import java.util.Scanner;

public class Switch3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("ù��° ���� �Է�: ");
		double op1 = sc.nextDouble(); //�Ҽ��� ���� ����
		System.out.print("����� �Է�: ");
		String oper = sc.next();
		System.out.print("�ι�° ���� �Է�: ");
		double op2 = sc.nextDouble(); //�Ҽ��� ���� ����
		double result = 0;
		
		switch (oper) {
		case "+":
			result = op1 + op2;
			break;
			
		case "-":
			result = op1 - op2;
			break;
			
		case "*":
			result = op1 * op2;
			break;
			
		case "/":
			if (op2 == 0) {
				System.out.println("�и� 0 ����!");
				// ���� ���α׷� ���� ����
				sc.close();
				System.exit(0);
			}
			result = op1 / op2;
			break;
			
		default:
			System.out.println("�߸��� ������ �Է�");
			sc.close();
			System.exit(0); // ����� �������� �ʰ� ���α׷� ����
		}
		System.out.println("------------------");
		System.out.println("�����: "+(int)result);
		// sc.close(); exit�Ǳ� ���� �ִ´�.

	}

}
