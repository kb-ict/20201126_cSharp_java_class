
public class MethodYeje2 {// 메소드 4번

	public static int plus(int num1, int num2) {
		int result = 0;
		result = num1 + num2;
		return result;

		// int == result 타입 일치
		// 정의먼저 > 사용 (main에서 했음..)
	}

	public static void main(String[] args) {
		int hap = plus(100, 200);
		System.out.println("hap: " + hap);
		System.out.println("hap: " + plus(200, 300));
	}
}
