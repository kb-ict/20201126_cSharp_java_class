import java.util.Scanner;

public class If_Dab1_gyesan {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("Num1 입력 => ");
		double op1 = s.nextDouble(); 
		System.out.print("Num2 입력 => ");
		double op2 = s.nextDouble(); 
		System.out.print("연산식 입력(+,-,*,/) => ");
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
				System.out.println("0으로 나눌 수 없습니다.");
			}
			s.close();
			System.exit(0);
			result = op1 / op2;
		}
		else {
			System.out.println(line);
			System.out.println("잘못된 연산자입니다.");
			s.close();
			System.exit(0);
		}
		System.out.println(line);
		// System.out.println((int)op1+" "+oper+" "+(int)op2+" = "+(int)result);
		System.out.printf("%d %s %d = %d", (int)op1, oper, (int)op2, (int)result);
		/* 
		 * %d : 정수
		 * %s : string
		 * \n : 뉴라인
		 * \t : 탭키
		 * %f : float
		 */
		s.close();
		//If_Dab1_yunnyon

	}

}
