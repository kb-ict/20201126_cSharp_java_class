import java.util.Scanner;

public class SmartHomeControl {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while (true) {
			String[] loginArr = login(sc);
			if (loginArr[0].equals("guest") && loginArr[1].equals("1234")) {
				guest();
				break;
			} else if (loginArr[0].equals("admin") && loginArr[1].equals("5678")) {
				admin();
				break;
			} else {
				System.out.println("------------------");
				System.out.println("ID와 PW를 잘못 입력");
			}
		}
	}

	public static String[] login(Scanner sc) {
		String name[] = new String[2];
		System.out.println("------------------");
		System.out.println(" 스마트 홈 제어 로그인");
		System.out.println("------------------");
		System.out.print("ID: ");
		String id = sc.next();
		name[0] = id;
		System.out.print("PW: ");
		String pw = sc.next();
		name[1] = pw;
		return name;
	}

	public static void guest() {
		System.out.println("------------------");
		System.out.println("   스마트 홈 제어");
		System.out.println("------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 종료");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
	}

	public static void admin() {
		System.out.println("--------------------");
		System.out.println("스마트 홈 제어 관리자 모드");
		System.out.println("--------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급 정지");
		System.out.println("6. 종료");
		System.out.println("--------------------");
		System.out.print("메뉴 선택: ");
	}
}
