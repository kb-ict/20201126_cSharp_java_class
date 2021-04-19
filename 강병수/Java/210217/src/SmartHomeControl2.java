import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SmartHomeControl2 {

	public static final String ADMIN_ID = "admin";
	public static final String ADMIN_PW = "5678";
	public static final String GUEST_ID = "guest";
	public static final String GUEST_PW = "1234";
	public static final String ADMIN_MODE = "admin";
	public static final String GUEST_MODE = "guest";
	public static final String OTHER_MODE = "other";
	
	public static final int ADMIN_TV_ON = 1;
	public static final int ADMIN_TV_OFF = 2;
	public static final int ADMIN_HEATER_ON = 3;
	public static final int ADMIN_CLEANER_ON = 4;
	public static final int ADMIN_EMERGENCY = 5;
	public static final int ADMIN_CONNECT = 6;
	public static final int ADMIN_EXIT = 7;
	public static final int ADMIN_LOGOUT = 8;
	
	public static final int GUEST_TV_ON = 1;
	public static final int GUEST_TV_OFF = 2;
	public static final int GUEST_HEATER_ON = 3;
	public static final int GUEST_CLEANER_ON = 4;
	public static final int GUEST_EXIT = 5;
	public static final int GUEST_LOGOUT = 6;
	
	
	
	

	public static void main(String[] args) {
		SerialPort serial = initSerial();
		openSerial(serial);
		
		Scanner sc = new Scanner(System.in);
		while (true) {
			String mode = login(sc);
			if (mode.equals(ADMIN_MODE)) {
				while (true) {
				if (adminwork(sc, serial) == false) {
					break;
					}
				}
			} 
			else if (mode.equals(GUEST_MODE)) {
				while (true) {
				if (!guestwork(sc, serial)) {
					break;
					}
				}
			} 
			else {
				System.out.println("ID와 비밀번호를 잘못 입력");
			}
		}
	}

	public static String login(Scanner sc) {
		System.out.println("------------------");
		System.out.println(" 스마트 홈 제어 로그인");
		System.out.println("------------------");
		System.out.print("ID: ");
		String id = sc.next();
		System.out.print("PW: ");
		String pw = sc.next();
		String mode;
		if (id.equals(GUEST_ID) && pw.equals(GUEST_PW)) {
			mode = GUEST_MODE;

		} else if (id.equals(ADMIN_ID) && pw.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;

		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}

	public static int guest(Scanner sc) {
		System.out.println("------------------");
		System.out.println("   스마트 홈 제어");
		System.out.println("------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 종료");
		System.out.println("6. 로그아웃");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		return sc.nextInt();
	}

	public static int admin(Scanner sc) {
		System.out.println("--------------------");
		System.out.println("스마트 홈 제어 관리자 모드");
		System.out.println("--------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급 정지");
		System.out.println("6. 재연결");
		System.out.println("7. 종료");
		System.out.println("8. 로그아웃");
		System.out.println("--------------------");
		System.out.print("메뉴 선택: ");
		return sc.nextInt();
	}
	
	public static boolean adminwork(Scanner sc, SerialPort serial) {
		switch (admin(sc)) {
		case ADMIN_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(ADMIN_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(ADMIN_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(ADMIN_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(ADMIN_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_EMERGENCY:
			System.out.println("긴급 정지");
			closeSerial(serial);
			break;
		case ADMIN_CONNECT:
			System.out.println("통신 재연결");
			if(!serial.isOpened()) {
				openSerial(serial);
			}
			break;
		case ADMIN_EXIT:
			System.out.println("프로그램 종료");
			sc.close();
			System.exit(0);
		case ADMIN_LOGOUT:
			System.out.println("로그아웃 완료");
			return false;
		}
		return true;
	}
	
	public static boolean guestwork(Scanner sc, SerialPort serial) {
		switch (guest(sc)) {
		case GUEST_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(GUEST_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(GUEST_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(GUEST_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(GUEST_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_EXIT:
			System.out.println("프로그램 종료");
			sc.close();
			System.exit(0);
		case GUEST_LOGOUT:
			System.out.println("로그아웃 완료");
			return false;
		}
		return true;
	}
	
	public static void closeSerial(SerialPort serial) {
		try {
			serial.closePort();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
	
	public static void openSerial(SerialPort serial) {
		try {
			serial.openPort();
			serial.setParams(SerialPort.BAUDRATE_9600, 
					SerialPort.DATABITS_8, 
					SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
	
	
	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);
		return serialPort;
	}
}

