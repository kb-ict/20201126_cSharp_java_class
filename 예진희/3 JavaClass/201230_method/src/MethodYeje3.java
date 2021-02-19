//패키지 없다.

public class MethodYeje3 {
	static int num = 200;	// 전역변수 global

	public static void func() {
		int num = 100;		// 지역변수 local
		System.out.println("func() num: " + num); // 중괄호 안 바로 위 변수 찾아감
	}

	public static void main(String[] args) {
		System.out.println("main() num: "+num);
		func();
	}

}
