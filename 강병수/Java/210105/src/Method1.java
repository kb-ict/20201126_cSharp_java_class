
public class Method1 {

	static int func() {
		System.out.println("값을 리턴하는 메소드");
		return 100;
	}
	
	public static void main(String[] args) {
		int num = func();
		System.out.println("num: " + num);
		System.out.println("num: " + func());
	}

}
