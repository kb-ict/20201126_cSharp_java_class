import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

//1-1. [로그인] ID: admin, PW:1234

//1-2. [관리자모드]
//--------------- 스마트홈 제어 관리자모드 ---------------
//1. TV켜기			LED ON
//2. TV끄기			LED OFF
//3. 보일러 동작		BUZZER
//4. 세탁기 동작		SERVO
//5. 긴급정지		serial.close();		(관리자만)
//6. 종료
//-------------------
//메뉴선택 : 

//2. [로그인] ID: guest, PW:1234
//5번빼고
public class Del_SerialMain1 {
	public static final String LINE = "--------------------";
	public static final String ADMIN_ID = "a";
	public static final String ADMIN_PW = "a";
	public static final String LOGMODE_ADMIN = "admin";

	public static final String GUEST_ID = "g";
	public static final String GUEST_PW = "g";
	public static final String LOGMODE_GUEST = "guest";

	public static final String LOGMODE_OTHER = "other";

	public static final int TV_ON = 1;
	public static final int TV_OFF = 2;
	public static final int HEAT_ON = 3;
	public static final int CLEANER_ON = 4;
	public static final int PAUSE = 5;
	public static final int PROGRAM_OFF = 6;
	public static final int PROGRAM_GUEST_OFF = 5;
	public static final int LOGOUT_ADMIN = 7;
	public static final int LOGOUT_GUEST = 6;

	public static final int CMD_TV_ON = 1;
	public static final int CMD_TV_OFF = 0;
	public static final int CMD_HEAT_ON = 2;
	public static final int CMD_CLEANER_ON = 3;

	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);
		return serialPort;
	}

	public static void openSerial(SerialPort serial) {
		try {
			serial.openPort();
			serial.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		SerialPort serial = initSerial();
		openSerial(serial);

		while (true) {
			String mode = log(s);
			if (mode.equals(LOGMODE_ADMIN)) {
				while (true) {
					if (adminWork(s) == false) {
						break;
					}
				}

			} else if (mode.equals(LOGMODE_GUEST)) {
				while (true) {
					if (!guestWork(s)) {
						break;
					}
				}

			} else {
				System.out.println("재입력요망");
			}
		}

	}

	private static boolean adminWork(Scanner s) {
		switch (adminMenu(s)) {
		case TV_ON:
			System.out.println("TV켜기");
			break;

		case TV_OFF:
			System.out.println("TV끄기");
			break;

		case HEAT_ON:
			System.out.println("보일러 동작");
			break;

		case CLEANER_ON:
			System.out.println("세탁기 동작");
			break;

		case PAUSE:
			System.out.println("긴급정지");
			break;

		case PROGRAM_OFF:
			System.out.println("종료");
			s.close();
			System.exit(0);
			break;
		case LOGOUT_ADMIN:
			return false;
		}
		return true;
	}

	private static int adminMenu(Scanner s) {
		System.out.println(LINE);
		System.out.println("스마트홈 제어 [관리자]");
		System.out.println(LINE);
		System.out.println("1. TV켜기	"); // LED ON
		System.out.println("2. TV끄기	"); // LED OFF
		System.out.println("3. 보일러 동작"); // BUZZER
		System.out.println("4. 세탁기 동작"); // SERVO
		System.out.println("5. 긴급정지"); // serial.closePort();
		System.out.println("6. 종료");
		System.out.println("7. 로그아웃");
		System.out.println(LINE);
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	private static boolean guestWork(Scanner s) {
		switch (guestMenu(s)) {
		case TV_ON:
			System.out.println("TV켜기");
			break;

		case TV_OFF:
			System.out.println("TV끄기");
			break;

		case HEAT_ON:
			System.out.println("보일러 동작");
			break;

		case CLEANER_ON:
			System.out.println("세탁기 동작");
			break;

		case PROGRAM_GUEST_OFF:
			System.out.println("종료");
			s.close();
			System.exit(0);
			break;

		case LOGOUT_GUEST:
			return false;

		}
		return true;
	}

	private static int guestMenu(Scanner s) {
		System.out.println(LINE);
		System.out.println("스마트홈 제어 [사용자]");
		System.out.println(LINE);
		System.out.println("1. TV켜기	"); // LED ON
		System.out.println("2. TV끄기	"); // LED OFF
		System.out.println("3. 보일러 동작"); // BUZZER
		System.out.println("4. 세탁기 동작"); // SERVO
		System.out.println("5. 종료");
		System.out.println("6. 로그아웃");
		System.out.println(LINE);
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	public static String log(Scanner s) {
		String mode;
		System.out.println(LINE);
		System.out.println("계정입력");
		System.out.println(LINE);
		System.out.print("ID : ");
		String id = s.next();
		System.out.print("PW : ");
		String pw = s.next();
		if (id.equals(ADMIN_ID) && pw.equals(ADMIN_PW)) {
			mode = LOGMODE_ADMIN;
		} else if (id.equals(GUEST_ID) && pw.equals(GUEST_PW)) {
			mode = LOGMODE_GUEST;
		} else {
			mode = LOGMODE_OTHER;
		}
		return mode;
	}
}
