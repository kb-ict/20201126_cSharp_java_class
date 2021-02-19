package operTest201208;

public class OpTest2 {

	public static void main(String[] args) {
		
		int num1 = 10;
		int num2 = 0;
		
		// ++, -- 증감연산자
		// ++ : 1 증가
		// -- : 1 감소
		num2 = num1++;
		System.out.println("num2 : "+ num2);
		
		num2 = ++num1;
		System.out.println("num2 : "+ num2);
		
		num2 = num1--;
		System.out.println("num2 : "+ num2);
		
		num2 = num1;
		System.out.println("num2 : "+ num2);
		
	}

}
