//패키지 없다.

public class ZMethodYeje3_201230 {
	static int num = 200;	// 전역변수 global
	// 중괄호 범위까지 변수 사용가능, 전역, 지역
	public static void func() {
		int num = 100;		// 지역변수 local
		System.out.println("func() num: " + num); // 중괄호 안 바로 위 변수 찾아감
	}

	// 변수 : 중괄호 > 없으면 > 전역에서 가져옴
	public static void main(String[] args) {
		System.out.println("main() num: "+num);
		func();
	}

}
