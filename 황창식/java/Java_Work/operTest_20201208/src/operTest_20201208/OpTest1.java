package operTest_20201208;

public class OpTest1 {

	public static void main(String[] args) {

		int num1 = 2, num2 = 3, num3 = 4;

		// 연산자 우선 순위
		// (*, /) > (+, -)
		int result = num1 + num2 - num3;
		System.out.println("num1 + num2 - num3 : " + result);

		// * > +
		result = num1 + num2 * num3;
		System.out.println("num1 + num2 * num3 : " + result);

		// (+) > *
		result = (num1 + num2) * num3;
		System.out.println("(num1 + num2) * num3 : " + result);

		result = num1 * num2 / num3;
		System.out.println("num1 * num2 / num3 : " + result);

		// ★★★★★나머지 연산자 : %
		// x % 2 --> 0, 1
		// x % 3 --> 0, 1, 2
		// x % 4 --> 0, 1, 2, 3
		// x % 9 --> 0 ~ 8
		result = num3 % num2;
		System.out.println("num3 % num2 : " + result);

	}

}
