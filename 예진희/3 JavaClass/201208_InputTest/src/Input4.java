import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		// 실습 5-2번 문제
		// 원주율을 저장하는 변수를 사용자가 입력하여 면적을 출력
		
		Scanner cal = new Scanner(System.in);
		System.out.print("원의 반지름을 입력: ");
		double r = cal.nextDouble();
		final double PI = 3.14;
		
		System.out.println("원의 면적은 "+(r*r*PI)+"입니다.");
		
		cal.close();

	}

}
