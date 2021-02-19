package operTest201208;

public class OpTest4 {

	public static void main(String[] args) {
		
		int num = 99;
		
		// && (논리 and 연산자)
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false--> false
		
		System.out.println("and 연산 : " + ((num >= 100) && (num<=200)));
		
		
		// || (논리 or 연산자)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		
		System.out.println("or 연산 : " + ((num >= 100) || (num<=200)));
		
		// ! (논리 not 연산자)
		// !(true) --> false
		// !(false) --> true
		System.out.println("not 연산 : " + !( num== 100));
		
		
		
		
		

	}

}
