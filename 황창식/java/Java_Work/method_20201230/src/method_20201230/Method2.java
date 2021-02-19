package method_20201230;

public class Method2 {
	public static void main(String[] args) {
		func();
		System.out.println("모든 메쏘드 종료");
	}
	
	public static void func() {
		System.out.println("func() 호출");
		// 메쏘드끼리 호출 가능
		func1();
	}
	
	public static void func1() {
		System.out.println("func1() 호출");
		func2();
	}
	
	public static void func2() {
		System.out.println("func2() 호출");
	}
}
