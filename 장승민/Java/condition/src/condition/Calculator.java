package condition;

import java.util.Scanner;

public class Calculator {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println(line);
		
		System.out.print("Num1 입력 => ");
		int num1 = sc.nextInt();
		System.out.print("Num2 입력 => ");
		int num2 = sc.nextInt();
		System.out.print("연산자 입력(+, -, *, /) => ");
		String op = sc.next();
		
		int result =0;
		
		if (op.equals("+"))
		{
			result=num1+num2;
			System.out.printf("%d + %d = %d",num1,num2,result);
		}
		else if(op.equals("-"))
		{
			result=num1-num2;
			System.out.printf("%d - %d = %d",num1,num2,result);
		}
		else if(op.equals("*"))
		{
			result=num1*num2;
			System.out.printf("%d * %d = %d",num1,num2,result);
		}
		else if(op.equals("/"))
		{
			double result1 =0;
			result1=(double)num1/(double)num2;
			System.out.printf("%s / %s = %s",num1,num2,result1);
		}
		else
		{
			System.out.println("잘못된 연산입니다.");
		}
	
	}

}
