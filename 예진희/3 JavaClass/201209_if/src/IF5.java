import java.util.Scanner;

public class IF5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		// s.next()= �������� / s.nextln()=���ͱ��� �޾Ƶ���
		
		String line = "----------------------";
		
		System.out.println(line);
		System.out.println("  ���� ���� �� ���� 1.0");
		System.out.println(line);
		System.out.print("- ȫ�浿 �Է�: ");
		String hong = s.next();
		System.out.print("- ��浿 �Է�: ");
		String kim = s.next();
		
		// String ���ڿ� ��
		if (hong.equals("����")) {
			if (kim.equals("����")) {
				System.out.println("�����ϴ�.");
			}
			else if (kim.equals("����")) {
				System.out.println("���� �̰���ϴ�.");
			}
			else if(kim.equals("��")) {
				System.out.println("ȫ�� �̰���ϴ�.");
				
			}
		}
		
		else if (hong.equals("����")) {
			if (kim.equals("����")) {
				System.out.println("ȫ�� �̰���ϴ�.");
			}
			else if (kim.equals("����")) {
				System.out.println("�����ϴ�.");
			}
			else {
				System.out.println("���� �̰���ϴ�.");
				
			}
		}
		
		else {//ȫ�浿 --> ��
			if (kim.equals("����")) {
				System.out.println("���� �̰���ϴ�.");
			}
			else if (kim.equals("����")) {
				System.out.println("ȫ�� �̰���ϴ�.");
			}
			else{
				System.out.println("�����ϴ�.");
				
				s.close();
			}
			
		}
	}
	
}
