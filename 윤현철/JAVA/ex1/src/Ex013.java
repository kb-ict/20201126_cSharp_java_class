import java.util.Scanner;

public class Ex013 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("---------------------------");
		System.out.println(" 담배 자판기 프로그램 v1.0 ");
		System.out.println("---------------------------");
		System.out.println("원하는 담배를 선택하세요.");
		System.out.println("1. 에쎄 골든 리프	: 6,000원");
		System.out.println("2. 에쎄 스페셜 골드	: 5,000원");
		System.out.println("3. 더원 블루		: 4,500원");
		System.out.println("4. 더원 오렌지		: 4,500원");
		System.out.println("5. 더원 화이트		: 4,500원");
		System.out.println("---------------------------");
		System.out.print("담배를 선택하세요 => ");
		int a = s.nextInt();
		switch (a) {
		case 1 :
			System.out.println("에쎄 골든 리프를 선택하셧습니다.");
			break;
		case 2 :
			System.out.println("에쎄 스페셜 골드를 선택하셧습니다.");
			break;
		case 3 :
			System.out.println("더원 블루를 선택하셧습니다.");
			break;
		case 4 :
			System.out.println("더원 오렌지를 선택하셧습니다.");
			break;
		default :
			System.out.println("더원 화이트를 선택하셧습니다.");
		}
		System.out.println("---------------------------");
		System.out.print("담배 금액을 선택하세요 => ");
		int b = s.nextInt();
		switch (a) {
		case 1 :
			if (b < 6000) {
				System.out.println("금액이 모자랍니다. 추가금액 " + (6000 - b) + "원을 투입하세요.");
				break;
			}
			else if (b == 6000) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
				break;
			}
			else {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + (b - 6000) + "원을 받으세요.");
				break;
			}
		case 2 :
			if (b < 5000) {
				System.out.println("금액이 모자랍니다. 추가금액 " + (5000 - b) + "원을 투입하세요");
				break;
			}
			else if (b == 5000) {
				System.out.println("에쎄 스페셜 골드를 구매했습니다.");
				break;
			}
			else {
				System.out.println("에쎄 스페셜 골드를 구매했습니다. 거스름돈 " + (b - 5000) + "원을 받으세요");
				break;
			}
		case 3 :
			if (b < 4500) {
				System.out.println("금액이 모자랍니다. 추가금액 " + (4500 - b) + "원을 투입하세요");
				break;
			}
			else if (b == 4500) {
				System.out.println("더원 블루를 구매했습니다.");
				break;
			}
			else {
				System.out.println("더원 블루를 구매했습니다. 거스름돈 " + (b - 4500) + "원을 받으세요");
				break;
			}
		case 4 :
			if (b < 4500) {
				System.out.println("금액이 모자랍니다. 추가금액 " + (4500 - b) + "원을 투입하세요");
				break;
			}
			else if (b == 4500) {
				System.out.println("더원 오렌지를 구매했습니다.");
				break;
			}
			else {
				System.out.println("더원 오렌지를 구매했습니다. 거스름돈 " + (b - 4500) + "원을 받으세요");
				break;
			}
		default :
			if (b < 4500) {
				System.out.println("금액이 모자랍니다. 추가금액 " + (4500 - b) + "원을 투입하세요");
			}
			else if (b == 4500) {
				System.out.println("더원 화이트를 구매했습니다.");
				break;
			}
			else {
				System.out.println("더원 화이트를 구매했습니다. 거스름돈 " + (b - 4500) + "원을 받으세요");
			}
			s.close();
		}
	}
}
