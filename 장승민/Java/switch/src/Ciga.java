import java.util.Scanner;

public class Ciga {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = 0 ;
		int result = 0;
		String name = "";
		String line = "----------------------------";
		System.out.println(line);
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println(line);
		System.out.println("원하는 담배를 선택하세요.");
		System.out.println("1. 에쎄 골든 리프 : 6,000원");
		System.out.println("2. 에쎄 스페셜 골드 : 5,000원");
		System.out.println("3. 더원 블루 : 4,500원");
		System.out.println("4. 더원 오렌지 : 4,500원");
		System.out.println("5. 더원 화이트 : 4,500원");
		System.out.println(line);

		System.out.print("담배를 선택하세요 => ");
		num = sc.nextInt();


		switch (num) {
		case 1:
			result = 6000;
			name = "에쎄 골든 리프";
			System.out.println(name+"를 주문했습니다.");
			break;
		case 2:
			result = 5000;
			name = "에쎄 스페셜 골드";
			System.out.println(name+"를 주문했습니다.");
			break;
		case 3:
			result = 4500;
			name = "더원 블루";
			System.out.println(name+"를 주문했습니다.");
			break;
		case 4:
			result = 4500;
			name = "더원 오렌지";
			System.out.println(name+"를 주문했습니다.");
			break;
		case 5:
			result = 4500;
			name = "더원 화이트";
			System.out.println(name+"를 주문했습니다.");
			break;

		default:
			break;
		}
		
		System.out.println(line);
		int cash = 0;
		System.out.print("담배 금액을 입금하세요 =>");
		cash = sc.nextInt();
		if (cash<4500) {
			System.out.println("금액이 부족합니다. 확인하시고 다시 시도하십시오.");
		}
		else {
			System.out.println(name + "를 구매했습니다. 거스름돈" + (cash-result)+"원을 받으세요.");	
		}


	}

}
