
public class Operation1 {

	public static void main(String[] args) {
		int num1 = 2, num2 = 5, num3 = 6;
		int sum1 = num1 + num2 - num3;
		//연산자 우선순위
		//() > *,/ > +, -
		System.out.println("sum1: " + sum1);
		//괄호를 먼저 처리
		int sum2 = num1 * (num2 - num3);
		System.out.println("sum2: " + sum2);
		int sum3 = num1 + num2 * num3;
		System.out.println("sum3: " + sum3);
		//% 나머지 연산자
		int sum4 = num3%num2;
		System.out.println("sum3: " + sum4);

	}

}
