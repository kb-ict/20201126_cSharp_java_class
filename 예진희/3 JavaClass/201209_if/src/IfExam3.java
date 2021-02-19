import java.util.Scanner;

public class IfExam3 {

	public static void main(String[] args) {
		// 3. 2개의 숫자를 입력받아서 +, -, *, / 연산자를 사용하는 간단한 계산기.
		String line = "-----------------------------";
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("   간단한 계산기 프로그램 v1.0");
		System.out.println(line);
		System.out.print(" 1. Num1 입력 => ");
		int num1 = sc.nextInt();
		System.out.print(" 2. Num2 입력 => ");
		int num2 = sc.nextInt();
		System.out.print(" 3. 연산자 입력(+, -, *, /) => ");
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
