import java.util.Scanner;

public class Yeje3 {

	public static void main(String[] args) {
		// ( ���� 2 ) ���� 2��, ��Ģ������ �̿��� ���� ���α׷�
				String line = "-----------------------------";
				Scanner sc = new Scanner(System.in);
				
				System.out.println(line);
				System.out.println("     ��� ���Ǳ� ���α׷� v1.0");
				System.out.println(line);
				System.out.println("���ϴ� ��踦 �޴����� �����ϼ���.\n");
				System.out.println("1. ���� ��� ����	6,000��");
				System.out.println("2. ���� ����� ���	5,000��");
				System.out.println("3. ���� ���	4,500��");
				System.out.println("4. ���� ������	4,500��");
				System.out.println("5. ���� ȭ��Ʈ	4,500��");
				System.out.println(line);
				System.out.print("��踦 �����ϼ��� => ");
				int dambeNum = sc.nextInt();
				
				String one = "���� ��� ����";
				String two = "���� ����� ���";
				String three = "���� ���";
				String four = "���� ������";
				String five = "���� ȭ��Ʈ";
				
				switch (dambeNum) {
				case 1:
					System.out.println(one+"�� �����ϼ̽��ϴ�.");
					break;
				case 2:
					System.out.println(two+"�� �����ϼ̽��ϴ�.");
					break;
				case 3:
					System.out.println(three+"�� �����ϼ̽��ϴ�.");
					break;
				case 4:
					System.out.println(four+"�� �����ϼ̽��ϴ�.");
					break;
				case 5:
					System.out.println(five+"�� �����ϼ̽��ϴ�.");
					break;
				default:
					System.out.println("1~5���߿��� �����ϼ���");
					sc.close();
					System.exit(0);
				}
				System.out.println(line);
				System.out.print("��� �ݾ��� �Ա��ϼ��� => ");
				int don = sc.nextInt();
				switch (dambeNum) {
				
				case 1:
					if (don<6000 || don<=0) {
						System.out.println("���� �����մϴ�.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(one+"�� �����߽��ϴ�.");
					System.out.println(" �Ž����� " +(don-6000)+"���� ��������.");
					break;
					
				case 2:
					if (don<5000 || don<=0) {
						System.out.println("���� �����մϴ�.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(two+"�� �����߽��ϴ�.");
					System.out.println(" �Ž����� " +(don-5000)+"���� ��������.");
					break;
					
				case 3:
					if (don<4500 || don<=0) {
						System.out.println("���� �����մϴ�.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(three+"�� �����߽��ϴ�.");
					System.out.println(" �Ž����� " +(don-4500)+"���� ��������.");
					break;
					
				case 4:
					if (don<4500 || don<=0) {
						System.out.println("���� �����մϴ�.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(four+"�� �����߽��ϴ�.");
					System.out.println(" �Ž����� " +(don-4500)+"���� ��������.");
					break;
					
				case 5:
					if (don<4500 || don<=0) {
						System.out.println("���� �����մϴ�.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(five+"�� �����߽��ϴ�.");
					System.out.println(" �Ž����� " +(don-4500)+"���� ��������.");
					break;
				}sc.close();
				
				
	}

}
