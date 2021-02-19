
public class Var4 {

	public static void main(String[] args) {
		
		/* 타입 형 변환 */
		byte b = 127;
		int i = 100;
		
		// 타입 변환 (형변환, 타입 캐스팅)
		// b가 자동으로 int 타입으로 변환
		System.out.println(b + i);
		
		int num = 10;
		int num2 = 4; // = int num 10. num2 = 4; (같은 뜻)
		System.out.println(num / num2); // 출력값 2 == System.out.println(10 / 4);
		
		// 4가 자동으로 4.0으로 변환 ex)평균값 = 정수 || 실수
		System.out.println(10.0 / 4);		
		System.out.println((char)65); //숫자를 문자로 형변환하여 출력하라
		
		String line = "----------------------------";
		System.out.println(line);
		System.out.println((int)2.9 + 1.8);			//정수 2와 1.8의 합
		System.out.println((int)(2.9 + 1.8));		//괄호안 먼저 연산하고 int형에 담는다.
		System.out.println((int)2.9 + (int)1.8);	//소수점을 버리고 정수형으로 변환하여 연산 > 출력
													//문자 > 숫자 / 정수 > 실수

		/* 타입 = 형변환 = 타입 캐스팅
		 * 로직은 직접 짜야함 */

	}

}
