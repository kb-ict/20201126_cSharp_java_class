import java.util.Scanner;

public class OpTest6Exam {

	public static void main(String[] args) {
		String line = "---------------------------------";
		int coin500 = 0;
		int coin100 = 0;
		int coin50 = 0;
		int jandon = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("       ���� ��ȯ�� ���α׷� 1.0");
		System.out.println(line);
		System.out.print(" * �ݾ��� �Է��ϼ���: ");
		int input = sc.nextInt();
		System.out.println(line);
		
		coin500 = input/500;
		int namg = input%500;
		//System.out.println("500�� ������		: "+namg);
		
		coin100 = namg / 100;
		//System.out.println("100�� ������		: "+namg);
		
		namg = namg % 100; // namg %= 100; ����ǥ��
		coin50 = namg / 50;
		
		namg = namg % 50;
		jandon = namg;
		/*
		 * coin100 = (input%500)/100; coin50 = ((input%500)%100)/50; jandon =
		 * ((input%500)%100)%50;
		 */
		
		System.out.println(" 1. ����� ����		: "+coin500+"��");
		System.out.println(" 2. ��� ����		: "+coin100+"��");
		System.out.println(" 3. ���ʿ� ����		: "+coin50+"��");
		System.out.println(" 4. �ٲ��� ���� �ܵ�	: "+jandon+"��");
		System.out.println(line);
		sc.close();

	}

}