//패키지 없다.

public class ZMethodYeje4_201230 {
	public static void main(String[] args) {
		int num = 10;
		// 매개변수로 10을 전달
		func(num);
		System.out.println("main() num: "+num);
	}
	
//2번형태
//-------------------------//변수선언과 동일 중괄호 안 까지 사용가능
	public static void func(int num) {
		//int num =0; 선언두번 불가능
		
		num = num+1; //------바로 위에 없으면 메소드 밖에서 찾음
		System.out.println("func() num: "+num);
	}
}
