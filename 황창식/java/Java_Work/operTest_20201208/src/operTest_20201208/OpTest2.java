package operTest_20201208;

public class OpTest2 {

	public static void main(String[] args) {

		int num1 = 10;
		int num2 = 0;
		
		// ++, -- 증감 연산자
		// 1증가, 1감소
		// 변수 처리를 먼저 한뒤 +1
		num2 = num1++;
		System.out.println("num2 : " + num2);
		// +1한뒤 변수 처리
		num2 = ++num1;
		System.out.println("num2 : " + num2);
		// 변수 처리를 먼저 한뒤 -1
		num2 = num1--;
		System.out.println("num2 : " + num2);
		// -1한뒤 변수 처리
		num2 = --num1;
		System.out.println("num2 : " + num2);

	}

}
