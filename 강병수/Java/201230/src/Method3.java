
public class Method3 {
	static int num = 200; // 전역 변수
	
	public static void func() {
		int num = 100; //지역 변수
		System.out.println("num: " + num);	
	}
	
	public static void main(String[] args) {
		System.out.println("num: " + num); //main 메소드에 선언된 num 변수가 없기 떄문에전역변수에서 가져옴
		func();
	}
}
