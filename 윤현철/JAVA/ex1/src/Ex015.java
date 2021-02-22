
public class Ex015 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("------------------------");
		System.out.println(" 5의 배수 출력 프로그램 v1.0");
		System.out.println("------------------------");
		for (int n = 1;n < 99; n++) {
			if ((n + 1) % 5 == 0) {
				System.out.print((n+1) + ", ");
			}
		}
		System.out.print(100);
	}
}
