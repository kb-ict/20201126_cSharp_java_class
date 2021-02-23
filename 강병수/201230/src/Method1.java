
public class Method1 {

	public static void main(String[] args) {
		System.out.println("func() 호출 전");
		func(); //메소드 사용(호출)
		System.out.println("func() 호출 후");
		
		System.out.println("반복문 메소드 호출");
		for (int i=0; i<5; i++) {
			func();
		}
	}
	
	//메소드 정의
	public static void func() {
		System.out.println("메소드 사용");
	}
}
