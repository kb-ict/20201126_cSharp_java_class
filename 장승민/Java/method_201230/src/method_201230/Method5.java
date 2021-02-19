package method_201230;

import java.util.Scanner;

public class Method5 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		divide(sc.nextInt(),sc.nextInt());// 스캐너로 입력도 쌉가능
		sc.close();
		divide(4,2);
		divide(4,0);
		System.out.println("메인() 종료");
	}

	public static void divide(int num1, int num2) {
		//num1 분자, num2 분모
		if (num2 == 0) {	// if (!num2)
			System.out.println("0으로 나눌 수 없습니다.");

			//void method에서 return을 사용하면 메쏘드 종료
			//System.exit(0) : 프로그램 강제 종료
			// return : 현재 실행중인 메쏘드 탈출
			return;		// main() line 7 출력 
			//System.exit(0);  main() line 7 출력 안됨 -> 프로그램이 강제 종료되었기 때문
		}
		System.out.println("나눗셈 결과 : "+ (num1/num2));
	}
}
