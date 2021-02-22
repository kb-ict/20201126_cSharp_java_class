
public class Func5 {	
	public static void main(String[] args) {
		divide(4, 0);	
		
	}
	
	public static void divide(int a, int b) {		
		if (b == 0) {
			System.out.println("0으로 나눌 수 없습니다.");
			System.exit(0);
		}
		System.out.println("나눗셈 결과: " + (a + b));
	}
}
