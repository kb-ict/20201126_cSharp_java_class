import java.io.IOException;
import java.util.Scanner;
public class Problem1 {

	public static void main(String[] args) throws Exception {
		Scanner menu = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("식당 메뉴 자동 주문 프로그램 v1.0 ");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("원하는 식사를 선택하세요.");
		System.out.println("a. 김치찌개:    5,000원");
		System.out.println("b. 된장찌개:    5,000원");
		System.out.println("c. 칼국수:     4,500원");
		System.out.println("d. 잔치국수:    4,000원");
		System.out.println("e. 비빔밥      5,000원");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("메뉴를 선택하세요: ");
		char food = (char) System.in.read();
		
		switch (food) {
		case 'a':
			System.out.println("김치찌개를 주문했습니다.");
			break;
		case 'b':
			System.out.println("된장찌개를 주문했습니다.");
			break;
		case 'c':
			System.out.println("칼국수를 주문했습니다.");
			break;
		case 'd':
			System.out.println("잔치국수룰 주문했습니다.");
			break;
		case 'e':
			System.out.println("비빔밥을 주문했습니다.");
			break;
		}
		menu.close();
	}

}
