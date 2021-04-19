import java.util.Scanner;

public class Problem3 {

	public static void main(String[] args) {
		Scanner Taba = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("   궐련 자판기 프로그램 v1.0   ");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("원하는 궐련을 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프     6,000원");
		System.out.println("2. 에쎼 스페셜 골드    5,000원");
		System.out.println("3. 더원 블루         4,500원");
		System.out.println("4. 더원 오렌지        4,500원");
		System.out.println("5. 더원 화이트        4,500원");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("담배를 선택하세요 => ");
		int num = Taba.nextInt();
		switch(num) {
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
			System.out.println("더원 오렌지를 선택하셨습니다.");
			break;
		case 5:
			System.out.println("더원 화이트를 선택하셨습니다.");
			break;
		default:
			System.out.println("번호를 잘못 입력하셨습니다.");
			System.exit(0);
		}
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("담배 금액을 입금하세요 => ");
		int cash = Taba.nextInt();
		if (cash < 4500) {
			System.out.println("돈이 부족합니다.");
			System.exit(0);
		}
		switch(num) {
		case 1:
			System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + (cash-6000) + "원을 받으세요.");
			break;
		case 2:
			System.out.println("에쎄 스페셜 골드를 구매했습니다. 거스름돈 " + (cash-5000) + "원을 받으세요.");
			break;
		case 3:
			System.out.println("더원 블루를 구매했습니다. 거스름돈 " + (cash-4500) + "원을 받으세요.");
			break;
		case 4:
			System.out.println("더원 오렌지를 구매했습니다. 거스름돈 " + (cash-4500) + "원을 받으세요.");
			break;
		case 5:
			System.out.println("더원 화이트를 구매했습니다. 거스름돈 " + (cash-4500) + "원을 받으세요.");
			break;
		}
		Taba.close();
	}
}

