import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// Scanner ��ü(s) ���� 
		// in = �Է�, out = ���
		Scanner s = new Scanner(System.in);
		System.out.print("�̸��� �Է�: ");
		
		// Ű����� ���ڿ� �Է¹���
		String name = s.nextLine();
		// ���� �Է� ����
		System.out.print("���� �Է�: ");
		int age = s.nextInt();
		
		System.out.println("");
		System.out.println("-------------------");
		System.out.println("�̸�: "+name);
		System.out.print("����: "+age);
		
		s.close();
		// ��Ȳ = �������, ���
	}

}
