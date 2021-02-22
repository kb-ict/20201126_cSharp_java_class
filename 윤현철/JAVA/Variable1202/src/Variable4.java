
public class Variable4 {

	public static void main(String[] args) {
		byte b = 127;
		int i = 100;
		
		// 타입 변환 (형변환, 타입 캐스팅)
		// b가 자동으로 int 타입으로 변환
		System.out.println(b + i);
		
		// 4가 자동으로 4.0으로 변환
		int num = 10;
		int num2 = 4;
		System.out.println(num / num2);
		System.out.println(10.0 / 4);
		
		// 강제
		System.out.println((char)65);
		
		System.out.println((int)2.9 + 1.8);
		System.out.println((int)(2.9 + 1.8));
		System.out.println((int)2.9 + (int)1.8);
		
		

	}

}
