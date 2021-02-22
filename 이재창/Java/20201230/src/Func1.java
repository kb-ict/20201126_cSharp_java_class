
public class Func1 {

	public static void main(String[] args) {
		System.out.println("func() 호출전");
		func();
		System.out.println("func() 호출후");
		
		for (int i = 0; i < 5; i++) {
			func();
		}

	}
	public static void func() {
		System.out.println("func()");
	}

}
