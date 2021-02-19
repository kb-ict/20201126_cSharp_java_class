
public class Operation4 {

	public static void main(String[] args) {
		int num = 99;
		// && (논리 and연산자)
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false --> false
		System.out.println("and 연산: " + ((num >= 100) && (num <= 200)));
		// || (논리 or연산자)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		System.out.println("or 연산: " + ((num >= 100) || (num <= 200)));
		// ! (논리 not연산자)
		// ! (true) --> false
		// ! (false) --> true
		System.out.println("not 연산: " + !(num == 100));
		// 3항 연산자
		//메쏘드 안에서 선언된 변수에 초기값이 없으면 쓰레기값이 들어간다
		int num1 = 10, num2 = 15;
		String str = "";
		str = (++num1 >= num2) ? "num1 이 크다": "num2가 크다";
		System.out.println(str);
	}

}
