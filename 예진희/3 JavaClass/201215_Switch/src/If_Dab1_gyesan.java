import java.util.Scanner;

public class If_Dab1_gyesan {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("Num1 �Է� => ");
		double op1 = s.nextDouble(); 
		System.out.print("Num2 �Է� => ");
		double op2 = s.nextDouble(); 
		System.out.print("����� �Է�(+,-,*,/) => ");
		String oper = s.next();
		double result = 0;
		String line = "----------------------";
		if (oper.equals("+")) {
			result = op1 + op2;
		}
		else if (oper.equals("-")) {
			result = op1 - op2;
		}
		else if (oper.equals("*")) {
			result = op1 * op2;
		}
		else if (oper.equals("/")) {
			if (op2==0) {
				System.out.println(line);
				System.out.println("0���� ���� �� �����ϴ�.");
			}
			s.close();
			System.exit(0);
			result = op1 / op2;
		}
		else {
			System.out.println(line);
			System.out.println("�߸��� �������Դϴ�.");
			s.close();
			System.exit(0);
		}
		System.out.println(line);
		// System.out.println((int)op1+" "+oper+" "+(int)op2+" = "+(int)result);
		System.out.printf("%d %s %d = %d", (int)op1, oper, (int)op2, (int)result);
		/* 
		 * %d : ����
		 * %s : string
		 * \n : ������
		 * \t : ��Ű
		 * %f : float
		 */
		s.close();
		//If_Dab1_yunnyon

	}

}
