//패키지 없다.

public class MethodYeje1 {
	public static void main(String[] args) {
		System.out.println("func() 호출 전");
		func(); // 메쏘드 사용(호출)
		System.out.println("func() 호출 후");
		
		System.out.println("-----------------\n반복문 메쏘드 호출\n-----------------");
		for (int i = 0; i < 5; i++) {
			func();
		}
	}
	
	// 메쏘드 선언(정의)
	public static void func() {
		System.out.println("메쏘드 사용");
	}

}
