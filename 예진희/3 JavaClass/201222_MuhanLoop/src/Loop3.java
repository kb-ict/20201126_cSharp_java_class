import java.util.Scanner;

public class Loop3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while (true) {
			System.out.println("------------------");
			System.out.println("메뉴 프로그램 테스트 1.0");
			System.out.println("------------------");
			System.out.println("1. 데이터 쓰기");
			System.out.println("2. 데이터 읽기");
			System.out.println("3. 프로그램 종료");
			System.out.println("------------------");
			System.out.print("메뉴 선택: ");
			int menu = sc.nextInt();
			switch (menu) {
			case 1:
				System.out.println("데이터 쓰기 작업 처리");
				break;

			case 2:
				System.out.println("데이터 읽기 작업 처리");
				break;

			case 3:
				System.out.println("프로그램 종료 처리");
				sc.close();
				System.exit(0);
				break; // 스위치 탈출하는 break;, 종료되기 때문에 생략가능
			default:
				System.out.println("잘못된 메뉴 선택!");
				break; // 생략 가능 어차피 마지막이라서

			}
		}
		// System.out.print("메뉴를 선택하시오 > ");
		// 메시지 que 기능, 계속 동작시 Terminate 불들어옴 적색 ■
	}
}
