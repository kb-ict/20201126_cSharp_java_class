import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain_mine {

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

	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOT_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_PAUSE = 5;
	static final int PROGRAM_EXIT_ADMIN = 6;
	static final int PROGRAM_EXIT_GUEST = 5;
	static final int PROGRAM_LOGOUT_GUEST = 6;
	static final int PROGRAM_LOGOUT_ADMIN = 7;

	static final int PROGRAM_ON = 1;
	static final int PROGRAM_OFF = 0;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HOT_ON = '2';
	static final int CMD_CLEANER_ON = '3';

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
		System.out.println("6. 종료");
		System.out.println("7. 로그아웃");
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
		System.out.println("5. 종료");
		System.out.println("6. 로그아웃");
		System.out.println("---------------");
		System.out.print("메뉴 입력 : ");
		return s.nextInt();
	}

	public static int adminWork(Scanner s, SerialPort serial) {
		int jonlyo = 0;
		switch (adminMenu(s)) {
		case TV_ON:
			System.out.println("  TV ON");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case TV_OFF:
			System.out.println("  TV OFF");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case HOT_ON:
			System.out.println("  보일러 가동");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_HOT_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case CLEANER_ON:
			System.out.println("  세탁기 가동");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case PROGRAM_PAUSE:
			System.out.println("  긴급정지");
			jonlyo = PROGRAM_ON;
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case PROGRAM_EXIT_ADMIN:
			System.out.println("종료");
			jonlyo = PROGRAM_ON;
			if (serial.isOpened() == true) {
				try {
					serial.closePort();
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				s.close();
				System.exit(0);
			} else {
				s.close();
				System.exit(0);
			}

		case PROGRAM_LOGOUT_ADMIN:
			System.out.println("관리자 로그아웃");
			jonlyo = PROGRAM_OFF;

		}
		return jonlyo;
	}

	public static int guestWork(Scanner s, SerialPort serial) {
		int jonlyo = 0;
		switch (guestMenu(s)) {
		case TV_ON:
			System.out.println("  TV ON");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case TV_OFF:
			System.out.println("  TV OFF");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case HOT_ON:
			System.out.println("  보일러 가동");
			jonlyo = PROGRAM_ON;
			try {
				serial.writeInt(CMD_HOT_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case CLEANER_ON:
			jonlyo = PROGRAM_ON;
			System.out.println("  세탁기 가동");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;

		case PROGRAM_EXIT_GUEST:
			jonlyo = PROGRAM_ON;
			System.out.println("종료");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			s.close();
			System.exit(0);

		case PROGRAM_LOGOUT_GUEST:
			jonlyo = PROGRAM_OFF;
			System.out.println("guest 로그아웃");
			break;
		}
		return jonlyo;
	}

	public static void main(String[] args) {
		SerialPort serial = initSerial();
		Scanner s = new Scanner(System.in);
		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				while (true) {
					// adminWork(s, serial);
					int junwon = adminWork(s, serial);
					if (junwon == 0) {
						break;
					}
				}
			} else if (mode.equals(GUEST_MODE)) {
				while (true) {
					// guestWork(s, serial);
					int junwon = guestWork(s, serial);
					if (junwon == 0) {
						break;
					}
				}
			} else {
				System.out.println("ID 또는 PW 불일치, 재입력");
			}
		}
	}

	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
//		if (portNames == null) {
//			System.out.println("포트없음 시스템 종료");
//			System.exit(0);
//		}
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
}
