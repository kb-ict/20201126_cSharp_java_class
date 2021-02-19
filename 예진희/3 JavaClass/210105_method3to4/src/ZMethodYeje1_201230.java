//패키지 없다.

public class ZMethodYeje1_201230 {
	public static void main(String[] args) {
		//2번형태 String[] args-> 스트링 배열, 메인문법은 고정
		//메소드 사용: 1. 정의 2. 다른메소드에서 호출하여 사용
		
		System.out.println("func() 호출 전");
		func(); // 메쏘드 사용(호출), 다른메소드 호출해야 사용가능
		System.out.println("func() 호출 후");
		
		System.out.println("-----------------\n반복문 메쏘드 호출\n-----------------");
		for (int i = 0; i < 5; i++) {
			func();
		}
	}
	
	// 메쏘드 선언(정의)
	// 1번형태
	public static void func() {
		System.out.println("메쏘드 사용");
	}

}
