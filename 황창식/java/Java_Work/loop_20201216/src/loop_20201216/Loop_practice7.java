package loop_20201216;

import java.util.Scanner;

public class Loop_practice7 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------------");
		System.out.println("간단 파일 관리 프로그램 v1.0");
		
		while (true) {
			System.out.println("-------------------------");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2. 파일 읽기");
			System.out.println("3. 종료");
			System.out.println("-------------------------");
			System.out.print("메뉴를 선택하세요 : ");
			int num1 = s.nextInt();
			switch (num1) {
			case 1:
				System.out.println("-------------------------");
				System.out.println("데이터 쓰기 작업 처리");
				break;
			case 2:
				System.out.println("-------------------------");
				System.out.println("데이터 읽기 작업 처리");
				break;
			case 3:
				System.out.println("-------------------------");
				System.out.println("프로그램 종료 처리");
				s.close();
				System.exit(0);
			default:
				System.out.println("-------------------------");
				System.out.println("잘못된 메뉴 선택!");
				break;
			}
			
		}

	}

}
