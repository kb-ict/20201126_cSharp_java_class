//패키지 없다.

public class ZMethodYeje2_201230 {
	//재귀호출, 메소드안에서 자기 호출
	public static void func() {
		System.out.println("func() 사용");
		func1();
	}

	public static void func1() {
		System.out.println("func1() 사용");
		func2();
	}
	
	public static void func2() {
		System.out.println("func2() 사용");
	}

	public static void main(String[] args) {
		//진입점 entury point, 메인부터 시작함
		func(); //메소드 내에서 다른 메소드 호출 가능
		System.out.println("모든 메쏘드 종료.");
	}

}
