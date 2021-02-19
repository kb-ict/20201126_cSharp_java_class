package variable_20201202;

public class Var03 {

	public static void main(String[] args) {

		byte b = 127;
		int i = 100;
		
		// 타입 자동 변환(형변환, 타입 캐스팅)
		
		// b가 자동으로 int 타입으로 변환
		System.out.println(b + i);
		
		int num1 = 10;
		int num2 = 4;
		System.out.println(num1 / num2);
		System.out.println(10 / 4);
		
		// 4가 자동으로 4.0으로 변환
		System.out.println(10.0 / 4);
		
		System.out.println((char)65);
		
		System.out.println((int)2.9 + 1.8);
		System.out.println((int)(2.9 + 1.8));
		System.out.println((int)2.9 + (int)1.8);
		
	}

}
