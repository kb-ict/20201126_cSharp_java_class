public class Var4 {

	public static void main(String[] args) {
		byte b = 127;
		int i = 100;
		
		// 타입 변환 (형변환, 타입 캐스팅)
		// b가 자동으로 int 타입으로 변환
		System.out.println(b + i);
		
		int num1 = 10, num2 = 4;
		System.out.println(num1/num2);
		// 4가 자동으로 4.0으로 변환
		System.out.println(10.0/4);
		//강제 형변환
		System.out.println((char)65);
		System.out.println((double)num1/(double)num2);
		System.out.println((int)2.9 + 1.8);
		System.out.println((int)(2.9 + 1.8));
		System.out.println((int)2.9 + (int)1.8);
		
		boolean isBlue = true; //변수 isBlue 선언과 동시에 true로 초기화
		boolean b1 = true;
		boolean b2 = false;
		System.out.println(b1); //b1이 지닌 값 출력
		System.out.println(b2);
		
		int num3 = 10;
		int num4 = 20;
		System.out.println(num3 < num4);
		System.out.println(num3 > num4);
		System.out.println(43<num4); //부등호의 참과 거짓 연산
		
	}

}
