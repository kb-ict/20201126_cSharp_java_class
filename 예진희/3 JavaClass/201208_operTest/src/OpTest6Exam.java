import java.util.Scanner;

public class OpTest6Exam {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "----------------------";
		int money500 = 0;
		int money100 = 0;
		int money50 = 0;
		int b = 0;
		
		System.out.println(line);
		System.out.println("   ���� ��ȯ�� ���α׷�");
		System.out.println(line);
		System.out.print("* ��ȯ�� �ݾ� �Է�: ");
		int money = sc.nextInt();
		System.out.println(line);
		
		money500 = money/500;
		money100 = (money%500)/100;
		money50 = ((money%500)%100)/50;
		b = ((money%500)%100)%50;
		System.out.println("1. ����� ����: "+money500+"��");
		System.out.println("2. ��� ����  : "+money100+"��");
		System.out.println("3. ���ʿ� ����: "+money50+"��");
		System.out.println("4. �ٲ��� ���� �ܵ�: "+b+"��");
		System.out.println(line);
		sc.close();

	}

}
