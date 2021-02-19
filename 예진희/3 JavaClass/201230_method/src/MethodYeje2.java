//패키지 없다.

public class MethodYeje2 {

	public static void func() {
		System.out.println("func() 사용");
		func1();
	}

	public static void func1() {
		System.out.println("func1() 사용");
		func2();
	}
	
	public static void func2() {
		System.out.println("func2() 사용");
	}

	public static void main(String[] args) {
		func(); //메소드 내에서 다른 메소드 호출 가능
		System.out.println("모든 메쏘드 종료.");
	}

}
