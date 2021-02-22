
public class Func2 {

	public static void main(String[] args) {
		func();

	}
	public static void func() {
		System.out.println("func()");
		func1();
	}
	
	public static void func1() {
		System.out.println("func1()");
		func2();
	}

	public static void func2() {
		System.out.println("func2()");
	}
}
