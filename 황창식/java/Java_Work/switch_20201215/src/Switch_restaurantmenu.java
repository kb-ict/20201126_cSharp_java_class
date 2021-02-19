import java.io.IOException;
import java.util.Scanner;

public class Switch_restaurantmenu {

	public static void main(String[] args) throws IOException {

		System.out.println("--------------------------");
		System.out.println("식당메뉴 자동주문 프로그램 v1.0");
		System.out.println("--------------------------");
		System.out.println("a. 김치찌개	: 5,000원");
		System.out.println("b. 된장찌개	: 5,000원");
		System.out.println("c. 칼국수		: 4,500원");
		System.out.println("d. 잔치국수	: 4,000원");
		System.out.println("e. 비빔밥		: 5,000원");
		System.out.println("--------------------------");
		System.out.print("메뉴를 선택하세요 : ");
		Scanner s = new Scanner(System.in);
		char menu = (char) System.in.read();
		// IOException : input/output exception
		// System.out.println(menu);
		System.out.println("--------------------------");
		switch (menu) {
		case 'a':
			System.out.println("김치찌개를 주문했습니다.\n감사합니다!");
			break;
		case 'b':
			System.out.println("된장찌개를 주문했습니다.\n감사합니다!");
			break;
		case 'c':
			System.out.println("칼국수를 주문했습니다.\n감사합니다!");
			break;
		case 'd':
			System.out.println("잔치국수를 주문했습니다.\n감사합니다!");
			break;
		case 'e':
			System.out.println("비빔밥를 주문했습니다.\n감사합니다!");
			break;
		default:
			System.out.println("잘못된 메뉴를 주문했습니다.\n감사합니다!");
			s.close();
			System.exit(0);
		}
		s.close();

	}

}
