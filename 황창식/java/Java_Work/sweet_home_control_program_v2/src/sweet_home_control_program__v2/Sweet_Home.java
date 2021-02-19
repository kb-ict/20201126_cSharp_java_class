package sweet_home_control_program__v2;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Sweet_Home {
	public static final int TV_ON = 1;
	public static final int TV_OFF = 2;
	public static final int BOILER_ON = 3;
	public static final int CLEANER_ON = 4;
	public static final int LOG_OUT = 5;

	public static final char CMD_TV_ON = '1';
	public static final char CMD_TV_OFF = '2';
	public static final char CMD_BOILER_ON = '3';
	public static final char CMD_CLEANER_ON = '4';

	public static final String ADMIN_ID = "admin";
	public static final String ADMIN_PW = "1234";

	public static final String GUEST_ID = "guest";
	public static final String GUEST_PW = "5678";

	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		while (true) {
			SerialPort serial = getSerial();
			if(serial == null) {
				System.out.println("연결된 포트가 없습니다.");
				System.out.println("기기를 포트에 연결해 주세요");
				try {
					serial.closePort();
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				continue;
			}
			String user = login(s);
			if (user.equals(ADMIN_MODE)) {
				adminWork(serial, s);
			} 
			else if (user.equals(GUEST_MODE)) {
				guestWork(serial, s);
			}
		}
	}

	public static String login(Scanner s) {
		while (true) {
			System.out.println("--------------");
			System.out.println("    Log In");
			System.out.println("--------------");
			System.out.print("  ID : ");
			String id = s.next();
			System.out.print("  PW : ");
			String password = s.next();
			if (id.equals(ADMIN_ID)) {
				if (password.equals(ADMIN_PW))
					return ADMIN_MODE;
				else
					System.out.println("ID 또는 비밀번호가 잘못되었습니다");
			} 
			else if (id.equals(GUEST_ID)) {
				if (password.equals(GUEST_PW))
					return GUEST_MODE;
				else
					System.out.println("ID 또는 비밀번호가 잘못되었습니다");
			} 
			else {
				System.out.println("사용자 정보를 찾을 수 없습니다.");
			}
		}
	}

	public static SerialPort getSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i] + " 연결 완료!");
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

	public static void adminWork(SerialPort serial, Scanner s) {
		final int EMERGANCY_EXIT = 6;
		final int PROGRAM_EXIT = 7;
		int menu = 0;
		while (true) {
			System.out.println("----------------------");
			System.out.println(" 스위트홈 제어 관리자 모드");
			System.out.println("----------------------");
			System.out.println("   1. TV 켜기");
			System.out.println("   2. TV 끄기");
			System.out.println("   3. 보일러 동작");
			System.out.println("   4. 세탁기 동작");
			System.out.println("   5. 로그아웃");
			System.out.println("   6. 긴급 정지");
			System.out.println("   7. 프로그램 종료");
			System.out.println("-------------------------");
			System.out.print("   메뉴 선택 : ");
			menu = s.nextInt();

			switch (menu) {
			case TV_ON:
				System.out.println("TV ON!");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV OFF!");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case BOILER_ON:
				System.out.println("BOILER ON!");
				try {
					serial.writeInt(CMD_BOILER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case CLEANER_ON:
				System.out.println("CLEANER ON!");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case LOG_OUT:
				System.out.println("LOG OUT!");
				return;
			case EMERGANCY_EXIT:
				System.out.println(serial.getPortName() + " DETATCHED!");
				try {
					serial.closePort();
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case PROGRAM_EXIT:
				System.out.println("BYE!");
				s.close();
				System.exit(0);
			default:
				System.out.println("잘못 입력하셨습니다.");
			}
		}
	}

	public static void guestWork(SerialPort serial, Scanner s) {
		final int PROGRAM_EXIT = 6;
		int menu = 0;
		while (true) {
			System.out.println("----------------");
			System.out.println(" 스위트홈 제어 모드");
			System.out.println("----------------");
			System.out.println("   1. TV 켜기");
			System.out.println("   2. TV 끄기");
			System.out.println("   3. 보일러 동작");
			System.out.println("   4. 세탁기 동작");
			System.out.println("   5. 로그아웃");
			System.out.println("   6. 프로그램 종료");
			System.out.println("-------------------");
			System.out.print("   메뉴 선택 : ");
			menu = s.nextInt();
			switch (menu) {
			case TV_ON:
				System.out.println("TV ON!");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV OFF!");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case BOILER_ON:
				System.out.println("BOILER ON!");
				try {
					serial.writeInt(CMD_BOILER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case CLEANER_ON:
				System.out.println("CLEANER ON!");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case LOG_OUT:
				System.out.println("LOG OUT!");
				return;
			case PROGRAM_EXIT:
				System.out.println("BYE!");
				s.close();
				System.exit(0);
			default:
				System.out.println("잘못 입력하셨습니다.");
			}
		}
	}
}