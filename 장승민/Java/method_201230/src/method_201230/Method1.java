package method_201230;

public class Method1 {

	public static void main(String[] args) {
		System.out.println("func() 호출전");
		func();		//메쏘드 사용(호출)
		System.out.println("func() 호출후");
		
		System.out.println("반복문 메쏘드 호출");
		for (int i = 0; i < 5; i++) {
			func();
		}
		
		
	}
	//	메쏘드 정의
	public static void func() {
		System.out.println("1.방식 메쏘드 사용");
	}
	
	
}
