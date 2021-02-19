import java.io.IOException;
import java.util.Scanner;

public class Switch_Practice {

	public static void main(String[] args) throws IOException {

		Scanner s = new Scanner(System.in);
		// 식당 메뉴 자동 주문 프로그램

//		System.out.println("-------------------------");
//		System.out.println("식당 메뉴 자동 주문 프로그램 v1.0");
//		System.out.println("-------------------------");
//		System.out.println("a. 김치찌개	: 5,000원");
//		System.out.println("b. 된장찌개	: 5,000원");
//		System.out.println("c. 칼국수		: 4,500원");
//		System.out.println("d. 잔치국수	: 4,000원");
//		System.out.println("e. 비빔밥		: 5,000원");
//		System.out.println("-------------------------");
//		System.out.print("메뉴를 선택하세요 : ");
//		char menu = (char)System.in.read();
//
//		System.out.println("-------------------------");
//		switch (menu) {
//		case 'a':
//			System.out.println("김치찌개를 주문했습니다.");
//			break;
//		case 'b':
//			System.out.println("된장찌개를 주문했습니다.");
//			break;
//		case 'c':
//			System.out.println("칼국수를 주문했습니다.");
//			break;
//		case 'd':
//			System.out.println("잔치국수를 주문했습니다.");
//			break;
//		case 'e':
//			System.out.println("비빔밥을 주문했습니다.");
//			break;
//		default:
//			System.out.println("잘못 입력하였습니다.");
//		}

		// 간단 계산기 프로그램

//		System.out.println("-------------------");
//		System.out.println("간단 계산기 프로그램 v2.0");
//		System.out.println("-------------------");
//		System.out.print("첫번째 숫자를 입력하세요 : ");
//		int num1 = s.nextInt();
//		System.out.println("-------------------");
//		System.out.print("두번째 숫자를 입력하세요 : ");
//		int num2 = s.nextInt();
//		System.out.println("-------------------");
//		System.out.print("연산자를 입력하세요(+, -, x, /) : ");
//		String str = s.next();
//		int result = 0;
//
//		System.out.println("-------------------");
//		switch (str) {
//		case "+":
//			result = num1 + num2;
//			break;
//		case "-":
//			result = num1 - num2;
//			break;
//		case "x":
//			result = num1 * num2;
//			break;
//		case "/":
//			result = num1 / num2;
//			break;
//		default:
//			System.out.println("잘못 입력하였습니다.");
//			s.close();
//			System.exit(0);
//		}
//		System.out.printf("%d %s %d = %d\n", num1, str, num2, result);

		// 담배 자판기 프로그램
		System.out.println("-------------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("원하는 담배를 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프	: 6,000원");
		System.out.println("2. 에쎼 스페셜 골드	: 5,000원");
		System.out.println("3. 더원 블루	: 4,500원");
		System.out.println("4. 더원 오랜지	: 4,500원");
		System.out.println("5. 더원 화이트	: 4,500원");
		System.out.println("-------------------------");
		System.out.print("담배를 선택하세요 : ");
		int menu2 = s.nextInt();

		System.out.println("-------------------------");

		switch (menu2) {
		case 1:
			System.out.println("에쎄 골든 리프를 선택하셨습니다");
			break;
		case 2:
			System.out.println("에쎄 스페셜 골드를 선택하셨습니다");
			break;
		case 3:
			System.out.println("더원 블루를 선택하셨습니다");
			break;
		case 4:
			System.out.println("더원 오랜지를 선택하셨습니다");
			break;
		case 5:
			System.out.println("더원 화이트를 선택하셨습니다");
			break;
		default:
			System.out.println("잘못 선택하셨습니다. 다시 시도해 주십시오.");
			s.close();
			System.exit(0);
		}

		System.out.println("-------------------------");
		System.out.print("담배 금액을 입금하세요 : ");
		int pay = s.nextInt();
		int change = 0;

		System.out.println("-------------------------");
		switch (menu2) {
		case 1:
			if (pay >= 6000) {
				change = pay - 6000;
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈" + change + "원을 받으세요.");
			} 
			else {
				System.out.println("금액이 부족합니다. 다시 이용해 주세요.");
			}
			break;
		case 2:
			if (pay >= 5000) {
				change = pay - 5000;
				System.out.println("에쎄 스페셜 골드를 구매했습니다. 거스름돈" + change + "원을 받으세요.");
			} 
			else {
				System.out.println("금액이 부족합니다. 다시 이용해 주세요.");
			}
			break;
		case 3:
			if (pay >= 4500) {
				change = pay - 4500;
				System.out.println("더원 블루를 구매했습니다. 거스름돈" + change + "원을 받으세요.");
			} 
			else {
				System.out.println("금액이 부족합니다. 다시 이용해 주세요.");
			}
			break;
		case 4:
			if (pay >= 4500) {
				change = pay - 4500;
				System.out.println("더원 오랜지를 구매했습니다. 거스름돈" + change + "원을 받으세요.");
			} 
			else {
				System.out.println("금액이 부족합니다. 다시 이용해 주세요.");
			}
			break;
		case 5:
			if (pay >= 4500) {
				change = pay - 4500;
				System.out.println("더원 화이트를 구매했습니다. 거스름돈 " + change + "원을 받으세요.");
			} 
			else {
				System.out.println("금액이 부족합니다. 다시 이용해 주세요.");
			}
			break;

		}

		s.close();

	}

}
