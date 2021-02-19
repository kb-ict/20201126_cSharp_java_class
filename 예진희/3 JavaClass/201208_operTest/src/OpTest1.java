public class OpTest1 {
	public static void main(String[] args) {
		// 콤마를 통해 한번에 입력
		int num1 = 2, num2 =3, num3 = 4;
		
		// 자바 = 공학용 계산기 동일, 연산자 우선순위 적용되어 계산됨
		// 연산자 우선순위 : () > *, / > +, -
		// 우선순위가 같으면 좌 > 우 순서
		int result = num1 + num2 - num3;
		System.out.println("result: "+result);	//결과값 : 1

		// 괄호를 먼저 처리
		int result2 = num1 + (num2 - num3);
		System.out.println("result2: "+result2);	//결과값 : 1
		
		// * > +
		result = num1 + num2 * num3;
		System.out.println("result: "+result);	//결과값 : 14
		
		// (+) > *
		result = (num1 + num2) * num3;
		System.out.println("result: "+result);	//결과값 : 20
		
		result = num1 * num2 / num3;	
		System.out.println("result: "+result);	//결과값 : 1
				// 나머지 연산자 4%3
		// X % 2 --> 0, 1 (나머지 = 뒤 숫자 -1의 값)
		
		/* result = num3 % num2; */
		result = 10 % 3;
		System.out.println("result: " + result);	//결과값 : 1
	}

}
