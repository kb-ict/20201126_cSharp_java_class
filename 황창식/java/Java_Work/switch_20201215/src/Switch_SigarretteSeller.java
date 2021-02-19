import java.util.Scanner;

public class Switch_SigarretteSeller {

	public static void main(String[] args) {

		System.out.println("---------------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("---------------------------");
		System.out.println("원하는 담배를 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프	: 6,000원");
		System.out.println("2. 에쎼 스페셜 골드	: 5,000원");
		System.out.println("3. 더원 블루	: 4,500원");
		System.out.println("4. 더원 오랜지	: 4,500원");
		System.out.println("5. 더원 화이트	: 4,500원");
		System.out.println("---------------------------");
		System.out.print("담배를 선택하세요 : ");

		Scanner s = new Scanner(System.in);
		int menu = s.nextInt();
		System.out.println("---------------------------");
		switch (menu) {
		case 1:
			System.out.println("에쎄 골든 리프를 선택하셨습니다.");
			break;
		case 2:
			System.out.println("에쎄 스페셜 골드를 선택하셨습니다.");
			break;
		case 3:
			System.out.println("더원 블루를 선택하셨습니다.");
			break;
		case 4:
			System.out.println("더원 오랜지를 선택하셨습니다.");
			break;
		case 5:
			System.out.println("더원 화이트를 선택하셨습니다.");
			break;
		default:
			System.out.println("메뉴를 잘못 선택하셨습니다.");
			s.close();
			System.exit(0);
		}
		System.out.println("---------------------------");
		
		System.out.print("담배 금액을 투입하세요 : ");
		int pay = s.nextInt();
		int change = 0;
		
		switch (menu) {
		case 1: // 에쎄 골든 리프 : 6,000 
			change = pay - 6000;
			if(change > 0) {
				
				System.out.println("에쎄 골든 리프를 구매하셨습니다.\n거스름돈 " + change + "원을 받으세요.");
			}
			else if(change == 0) {
				System.out.println("에쎄 골든 리프를 구매하셨습니다.\n감사합니다.");
			}
			else {
				// Math.abs() : 절대값을 만드는 메소드
				System.out.println("금액이 부족합니다.\n추가금액 " + Math.abs(change) + "원을 투입하세요.");
			}
			break;
		case 2:
			change = pay - 5000;
			if(change > 0) {
				
				System.out.println("에쎄 스페셜 골드를 구매하셨습니다.\n거스름돈 " + change + "원을 받으세요.");
			}
			else if(change == 0) {
				System.out.println("에쎄 스페셜 골드를 구매하셨습니다.\n감사합니다.");
			}
			else {
				System.out.println("금액이 부족합니다.\n추가금액 " + Math.abs(change) + "원을 투입하세요.");
			}
			break;
		case 3:
			change = pay - 4500;
			if(change > 0) {
				
				System.out.println("더원 블루를 구매하셨습니다.\n거스름돈 " + change + "원을 받으세요.");
			}
			else if(change == 0) {
				System.out.println("더원 블루를 구매하셨습니다.\n감사합니다.");
			}
			else {
				change = 4500 - pay;
				System.out.println("금액이 부족합니다.\n추가금액 " + Math.abs(change) + "원을 투입하세요.");
			}
			break;
		case 4:
			change = pay - 4500;
			if(change > 0) {
				
				System.out.println("더원 오랜지를 구매하셨습니다.\n거스름돈 " + change + "원을 받으세요.");
			}
			else if(change == 0) {
				System.out.println("더원 오랜지를 구매하셨습니다.\n감사합니다.");
			}
			else {
				change = 4500 - pay;
				System.out.println("금액이 부족합니다.\n추가금액 " + Math.abs(change) + "원을 투입하세요.");
			}
			break;
		case 5:
			change = pay - 4500;
			if(change > 0) {
				
				System.out.println("더원 화이트를 구매하셨습니다.\n거스름돈 " + change + "원을 받으세요.");
			}
			else if(change == 0) {
				System.out.println("더원 화이트를 구매하셨습니다.\n감사합니다.");
			}
			else {
				change = 4500 - pay;
				System.out.println("금액이 부족합니다.\n추가금액 " + Math.abs(change) + "원을 투입하세요.");
			}
			break;
		default:
			System.out.println("메뉴를 잘못 선택하셨습니다.");
			s.close();
			System.exit(0);
		}
		
	}

}
