import java.util.Scanner;

public class Ex011 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("-----------------------------");
		System.out.println(" 식당 메뉴 자동 주문 프로그램 v1.0 ");
		System.out.println("-----------------------------");
		System.out.println("원하는 메뉴를 선택하세요.");
		System.out.println("1. 김치찌개	: 5,000원");
		System.out.println("2. 된장찌개	: 5,000원");
		System.out.println("3. 칼국수		: 4,500원");
		System.out.println("4. 잔치국수	: 4,000원");
		System.out.println("5. 비빔밥  	: 5,000원");
		System.out.print("메뉴를 선택하세요 : ");
		int a = s.nextInt();
		switch (a) {
		case 1 :
			System.out.println("김치찌개를 주문했습니다.");
			break;
		case 2 :
			System.out.println("된장찌개를 주문했습니다.");
			break;
		case 3 :
			System.out.println("칼국수를 주문했습니다.");
			break;
		case 4 :
			System.out.println("잔치국수를 주문했습니다.");
			break;
		default :
			System.out.println("비빔밥을 주문했습니다.");
		}
		s.close();
	}

}
