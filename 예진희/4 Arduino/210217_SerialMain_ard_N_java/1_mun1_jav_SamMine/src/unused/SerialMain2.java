package unused;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain2 {

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
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HEATER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static final int MENU_TV_ON = '1';
	public static final int MENU_TV_OFF = '2';
	public static final int MENU_HEATER_ON = '3';
	public static final int MENU_CLEANER_ON = '4';
	public static final int MENU_GUEST_EXIT = '5';
	public static final int MENU_EMARGENCY = '5';
	private static final int MENU_ADMIN_LOGOUT = '6';
	public static final int MENU_ADMIN_EXIT = '7';
	private static final int MENU_GUEST_LOGOUT = 5;

	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		return serialPort;
	}

	public static String login(Scanner s) {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("---------------");
		System.out.print("ID: ");

		String id = s.next();
		System.out.print("PW: ");
		String passWd = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && passWd.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else if (id.equals(GUEST_ID) && passWd.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}

	public static int adminMenu(Scanner s) {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 [관리자]");
		System.out.println("---------------");
		System.out.println("1. TV켜기");
		System.out.println("2. TV끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급정지");
		System.out.println("6. 관리자 로그아웃");
		System.out.println("7. 종료");
		System.out.println("---------------");
		System.out.print("메뉴 입력 : ");
		return s.nextInt();
	}

	public static int guestMenu(Scanner s) {
		System.out.println("---------------");
		System.out.println("스마트홈 제어 [사용자]");
		System.out.println("---------------");
		System.out.println("1. TV켜기");
		System.out.println("2. TV끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 사용자 로그아웃");
		System.out.println("6. 종료");
		System.out.println("---------------");
		System.out.print("메뉴 입력 : ");
		return s.nextInt();
	}

	public static boolean adminWork(Scanner s, SerialPort serial) {
		switch (adminMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV켜기");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV끄기");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("보일러 동작");
			try {
				serial.writeInt(CMD_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("세탁기 동작");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_EMARGENCY:
			System.out.println("긴급정지");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case MENU_ADMIN_LOGOUT:
			System.out.println("관리자 로그아웃");
			return false;

		case MENU_ADMIN_EXIT:
			System.out.println("종료");
			s.close();
			System.exit(0);

		default:
			break;
		}
		return true;
	}

	public static boolean guestWork(Scanner s, SerialPort serial) {
		switch (guestMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV켜기");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV끄기");
			break;
		case MENU_HEATER_ON:
			System.out.println("보일러 동작");
			break;
		case MENU_CLEANER_ON:
			System.out.println("세탁기 동작");
			break;

		case MENU_GUEST_LOGOUT:
			System.out.println("로그아웃");
			s.close();
		case MENU_GUEST_EXIT:
			System.out.println("종료");
			s.close();
			System.exit(0);
		default:
			break;
		}
		return true;
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		SerialPort serial = initSerial();

		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				while (true) {
					if (adminWork(s, serial) == false) {
						break;
					}
				}
			} else if (mode.equals(GUEST_MODE)) {
				while (true) {
					if (!guestWork(s, serial)) {
						break;
					}
				}
			} else {
				System.out.println("ID 또는 PW 불일치, 재입력");
			}
		}
	}
}
