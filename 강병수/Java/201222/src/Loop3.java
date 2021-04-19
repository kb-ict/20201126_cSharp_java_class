import java.util.Scanner;
public class Loop3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while(true) {
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("메뉴 프로그램 테스트 1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("1. 데이터 쓰기");
		System.out.println("2. 데이터 읽기");
		System.out.println("3. 프로그램 종료");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("번호를 선택하십시오: ");
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
			break;
		default:
			System.out.println("잘못된 입력!");
		
		}
		}
	
		
	}

}