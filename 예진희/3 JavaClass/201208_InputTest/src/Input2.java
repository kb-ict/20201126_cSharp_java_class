import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		Scanner sc2 = new Scanner(System.in);
		System.out.print("ù��° ������ �Է�: ");
		int num1 = sc2.nextInt();
		System.out.print("�ι�° ������ �Է�: ");
		int num2 = sc2.nextInt();
		System.out.print("����° ������ �Է�: ");
		int num3 = sc2.nextInt();
		// ��ȣ�� �ִ�: �޼���, ���ڿ�: nexeline1 or next
		int sum = num1 + num2 + num3;
		int ave = sum / 3;
		
		System.out.println("�հ�: "+sum);
		System.out.println("���: "+ave);
		
		sc2.close();

	}

}
