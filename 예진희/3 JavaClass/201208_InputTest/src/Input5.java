import java.util.Scanner;

public class Input5 {

	public static void main(String[] args) {
		// �ǽ� 5-3�� ����
		// ��, ��, ��, �� ������ �Է��ϰ� ��հ��� ������ ���
		
		Scanner sc = new Scanner(System.in);
		System.out.print("1. ��������: ");
		int kr = sc.nextInt();
		System.out.print("2. ��������: ");
		int eng = sc.nextInt();
		System.out.print("3. ��������: ");
		int math = sc.nextInt();
		System.out.print("4. ��������: ");
		int science = sc.nextInt();	
				
		int total = kr+eng+math+science;
		int ave = (kr+eng+math+science)/4;
		
		System.out.println("��ü���� ������: "+total);
		System.out.println("���: "+ave);
		sc.close();

	}

}
