import java.util.Scanner;

public class Yeje2 {

	public static void main(String[] args) {
		// ( ���� 2 ) ���� 2��, ��Ģ������ �̿��� ���� ���α׷�
		String line = "-----------------------------";
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("    ������ ���� ���α׷� v1.0");
		System.out.println(line);
		System.out.print("1. Num1 �Է� => ");
		int num1 = sc.nextInt();
		System.out.print("2. Num2 �Է� => ");
		int num2 = sc.nextInt();
		System.out.print("3. ������ �Է� => ");
		String oper = sc.next();
		int gye = 0;
		
		switch (oper) {
		case "+":
			gye = num1 + num2;
			break;
			
		case "-":
			gye = num1 - num2;
			break;
			
		case "X":
			gye = num1 * num2;
			break;
			
		case "/":
			if (num2==0) {
				System.out.println(line);
				System.out.println("0���� ���� �� �����ϴ�.");
			}
			sc.close();
			System.exit(0);
			gye = num1 / num2;
			break;
			
		default : {
				System.out.println(line);
				System.out.println("+, -, X, /�߿��� �Է��ϼ���.");
				sc.close();
				System.exit(0);
			}
			
		}
		
		System.out.println(line);
		System.out.printf("%d %s %d = %d",num1, oper, num2, gye);
		sc.close();

	}

}
