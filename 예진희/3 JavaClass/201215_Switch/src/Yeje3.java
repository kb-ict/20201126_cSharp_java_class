import java.util.Scanner;

public class Yeje3 {

	public static void main(String[] args) {
		// ( 예제 2 ) 숫자 2개, 사칙연산자 이용한 계산기 프로그램
				String line = "-----------------------------";
				Scanner sc = new Scanner(System.in);
				
				System.out.println(line);
				System.out.println("     담배 자판기 프로그램 v1.0");
				System.out.println(line);
				System.out.println("원하는 담배를 메뉴에서 선택하세요.\n");
				System.out.println("1. 에쎄 골든 리프	6,000원");
				System.out.println("2. 에쎄 스페셜 골드	5,000원");
				System.out.println("3. 더원 블루	4,500원");
				System.out.println("4. 더원 오렌지	4,500원");
				System.out.println("5. 더원 화이트	4,500원");
				System.out.println(line);
				System.out.print("담배를 선택하세요 => ");
				int dambeNum = sc.nextInt();
				
				String one = "에쎄 골든 리프";
				String two = "에쎄 스페셜 골드";
				String three = "더원 블루";
				String four = "더원 오렌지";
				String five = "더원 화이트";
				
				switch (dambeNum) {
				case 1:
					System.out.println(one+"를 선택하셨습니다.");
					break;
				case 2:
					System.out.println(two+"를 선택하셨습니다.");
					break;
				case 3:
					System.out.println(three+"를 선택하셨습니다.");
					break;
				case 4:
					System.out.println(four+"를 선택하셨습니다.");
					break;
				case 5:
					System.out.println(five+"를 선택하셨습니다.");
					break;
				default:
					System.out.println("1~5번중에서 선택하세요");
					sc.close();
					System.exit(0);
				}
				System.out.println(line);
				System.out.print("담배 금액을 입금하세요 => ");
				int don = sc.nextInt();
				switch (dambeNum) {
				
				case 1:
					if (don<6000 || don<=0) {
						System.out.println("돈이 부족합니다.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(one+"를 구매했습니다.");
					System.out.println(" 거스름돈 " +(don-6000)+"원을 받으세요.");
					break;
					
				case 2:
					if (don<5000 || don<=0) {
						System.out.println("돈이 부족합니다.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(two+"를 구매했습니다.");
					System.out.println(" 거스름돈 " +(don-5000)+"원을 받으세요.");
					break;
					
				case 3:
					if (don<4500 || don<=0) {
						System.out.println("돈이 부족합니다.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(three+"를 구매했습니다.");
					System.out.println(" 거스름돈 " +(don-4500)+"원을 받으세요.");
					break;
					
				case 4:
					if (don<4500 || don<=0) {
						System.out.println("돈이 부족합니다.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(four+"를 구매했습니다.");
					System.out.println(" 거스름돈 " +(don-4500)+"원을 받으세요.");
					break;
					
				case 5:
					if (don<4500 || don<=0) {
						System.out.println("돈이 부족합니다.");
						sc.close();
						System.exit(0);
						}
					
					System.out.print(five+"를 구매했습니다.");
					System.out.println(" 거스름돈 " +(don-4500)+"원을 받으세요.");
					break;
				}sc.close();
				
				
	}

}
