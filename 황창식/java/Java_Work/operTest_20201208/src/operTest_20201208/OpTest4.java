package operTest_20201208;

public class OpTest4 {

	public static void main(String[] args) {

		int num = 99;
		System.out.println("num = 99");
		// && 연산자(논리 'and'연산자)
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false --> false
		System.out.println("and 연산(num >= 100 && num <= 200) : " + (num >= 100 && num <= 200));
		// true and false => false

		// || 연산자(논리 'or'연산자)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		System.out.println("or 연산(num >= 100 || num <= 200) : " + (num >= 100 || num <= 200));
		// true or false => true

		// ! (논리 'not'연산자)
		// !(true) = false
		// !(false) = true
		System.out.println("not 연산(!(num == 100)) : " + !(num == 100));

	}

}
