import java.util.Scanner;

public class IfExam3 {

	public static void main(String[] args) {
		// 3. 2���� ���ڸ� �Է¹޾Ƽ� +, -, *, / �����ڸ� ����ϴ� ������ ����.
		String line = "-----------------------------";
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("   ������ ���� ���α׷� v1.0");
		System.out.println(line);
		System.out.print(" 1. Num1 �Է� => ");
		int num1 = sc.nextInt();
		System.out.print(" 2. Num2 �Է� => ");
		int num2 = sc.nextInt();
		System.out.print(" 3. ������ �Է�(+, -, *, /) => ");
		String str = sc.next();
		System.out.println(line);
		String gongbak = "    ";
			
		if (str.equals("+")) {
			System.out.println(gongbak+num1+"+"+num2+" = "+(num1+num2));
		}
		else if(str.equals("-")) {
			System.out.println(gongbak+num1+"-"+num2+" = "+(num1-num2));
		}
		else if(str.equals("*")) {
			System.out.println(gongbak+num1+"*"+num2+" = "+(num1*num2));
		}
		else {
			System.out.println(gongbak+num1+"/"+num2+" = "+(num1/num2));
		}
		
		sc.close();
	}

}
