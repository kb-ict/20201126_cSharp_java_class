import java.util.Scanner;

public class Loop3 {

	public static void main(String[] args) {
		while(true) {
			System.out.println("----------------------");
			System.out.println(" 메뉴 프로그램 테스트 v1.0");
			System.out.println("----------------------");
			System.out.println("1. 데이터 쓰기");
			System.out.println("2. 데이터 읽기");
			System.out.println("3. 프로그램 종료");
			System.out.println("----------------------");
			System.out.print("메뉴 선택 : ");
			Scanner s= new Scanner(System.in);
			int menu = s.nextInt();
			switch(menu) {
			case 1:
				System.out.println("데이터 쓰기 작업 처리");
				break;
			case 2:
				System.out.println("데이터 읽기 작업 처리");
				break;
			case 3:
				System.out.println("프로그램 종료 처리");
				s.close();
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 메뉴 선택!");
				break;
			}
		}			
	}
}
