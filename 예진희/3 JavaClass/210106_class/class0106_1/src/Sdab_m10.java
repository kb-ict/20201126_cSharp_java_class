import java.util.Scanner;

public class Sdab_m10 {
	/*10. 입력 받은 수의 팩토리얼을 구하는 프로그램.
	 * 조건1) 숫자는 main()에서 입력받음.
	 * 조건2) 3을 입력하면 3!(3x2x1), 4를 입력하면 4!(4x3x2x1)이 동작.
	 * 조건3) 재귀함수(메쏘드)로 구현.
	 */	
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in); //객체생성 = 클래스 변수 선언
		System.out.print("팩토리얼 수 입력 : ");
		int n = s.nextInt();
		s.close();
		
		int result = factorial(n);
		System.out.println(n+"! = "+result);
	}
	
	public static int factorial(int n) {
		if(n==1) {
			return 1;
		}
		else {
			return n*factorial(n-1);
			//return n*factorial(n-1) + 2;
		}
		// 자료구조: stack 공간에 3* 값 있음 
		// 3* > 호출 > 2*..> 1 ...
		// n-1 =0 > 1*2*3 거꾸로 타고 들어감
		// 메소드도 따로 공간 ㅇ
		// 재귀함수 사용 > c, d탐색기 만들 수 ㅇ
	}
}
