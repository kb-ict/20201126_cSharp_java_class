package unused;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain1 {

//	1-1. [로그인] ID: admin, PW:1234

//	1-2. [관리자모드]
//	--------------- 스마트홈 제어 관리자모드 ---------------
//	1. TV켜기			LED ON
//	2. TV끄기			LED OFF
//	3. 보일러 동작		BUZZER
//	4. 세탁기 동작		SERVO
//	5. 긴급정지		serial.close();		(관리자만)
//	6. 종료
//	-------------------
//	메뉴선택 : 

//	2. [로그인] ID: guest, PW:1234
//	5번빼고
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		while (true) {
			String[] loginArr = login(s);
			if (loginArr[0].equals(ADMIN_ID) && loginArr[1].equals(ADMIN_PW)) {
				System.out.println("관리자 모드");
				adminMenu();
				break;
			} else if (loginArr[0].equals(GUEST_ID) && loginArr[1].equals(GUEST_PW)) {
				System.out.println("사용자 모드");
				guestMenu();
				break;
			} else {
				System.out.println("ID 또는 비밀번호가 잘못됨");
				System.out.println("재입력 요함");
			}
		}

	}

	public static String[] login(Scanner s) {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("---------------");
		System.out.print("ID: ");

		String id = s.next();
		System.out.print("PW: ");
		String passWd = s.next();
		String[] loginData = new String[2];
		loginData[0] = id;
		loginData[1] = passWd;
		return loginData;
	}

	public static void adminMenu() {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 관리자모드");
		System.out.println("---------------");
		System.out.println("1. TV켜기");
		System.out.println("2. TV끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급정지");
		System.out.println("6. 종료");
	}

	public static void guestMenu() {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 사용자모드");
		System.out.println("---------------");
		System.out.println("1. TV켜기");
		System.out.println("2. TV끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 종료");
	}

}
