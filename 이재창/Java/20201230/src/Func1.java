
public class Func1 {

	public static void main(String[] args) {
		System.out.println("func() ȣ����");
		func();
		System.out.println("func() ȣ����");
		
		for (int i = 0; i < 5; i++) {
			func();
		}

	}
	public static void func() {
		System.out.println("func()");
	}

}
