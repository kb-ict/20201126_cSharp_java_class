package method_20210105;

public class Method1 {
	static int func() {
		System.out.println("값을 리턴하는 메쏘드");
		return 100;
	}
	
	public static void main(String[] args) {
		int num = func(); // func()의 return값을 num로 반환한다.
		// 메쏘드의 타입과 반환받는 변수의 타입을 일치
		System.out.println("num : " + num);
		System.out.println("num : " + func());
	}

}
