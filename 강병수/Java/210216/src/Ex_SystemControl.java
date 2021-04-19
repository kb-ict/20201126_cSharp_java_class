import java.util.Scanner;

public class Ex_SystemControl {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int BOILER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while (true) {
			switch (control(sc)) {
			case TV_ON:
				System.out.println("TV 켜기");
				break;
			case TV_OFF:
				System.out.println("TV 끄기");
				break;
			case BOILER_ON:
				System.out.println("보일러 작동");
				break;
			case CLEANER_ON:
				System.out.println("세탁기 작동");
				break;
			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				System.exit(0);
				sc.close();
				break;
			}
		}
	}

	public static int control(Scanner sc) {
		System.out.println("=====================");
		System.out.println("  스마트 홈 제어 v1.0");
		System.out.println("=====================");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 프로그램 종료");
		System.out.println("=====================");
		System.out.print("메뉴 선택: ");
		return sc.nextInt();

	}
}