//패키지 없다.

public class ZMethodYeje5_201230 {
	public static void devide(int num1, int num2) { //* 맞추기 int num1, int num2
		// num1: 분자
		// num2: 분모
		if (num2 == 0) { // if (!num2)
			System.out.println("0으로 나눌 수 없습니다.");
			// void method일때만 return을 사용하면 메소드 탈출
			// System.exit(0): 프로그램 강제 종료
			
			// 아래에 여러줄의 실행문이 있더라도 
			// 현재 실행중인 메쏘드 탈츨
			return;
			// System.exit(0); **
		}
		System.out.println("나눗셈 결과: " + (num1 / num2));
	}

	public static void main(String[] args) {
		devide(4, 2); //* 맞추기
		devide(4, 0);
		System.out.println("메인() 종료"); //** 사용시 미출력
	}
}
