import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain3 {
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";
	
	public static final int MENU_TV_ON = 1;
	public static final int MENU_TV_OFF = 2;
	public static final int MENU_HEATER_ON = 3;
	public static final int MENU_CLEANER_ON = 4;
	public static final int MENU_GUEST_LOGOUT = 5;
	public static final int MENU_ADMIN_LOGOUT = 6;
	public static final int MENU_GUEST_EXIT = 6;
	public static final int MENU_ADMIN_EXIT = 7;
	public static final int MENU_EMARGENCY = 5;
	
	static final int CMD_TV_ON 		= '1';
	static final int CMD_TV_OFF 	= '0';
	static final int CMD_HEATER_ON 	= '2';
	static final int CMD_CLEANER_ON = '3';
	
	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = 
				new SerialPort(portNames[0]);
		
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, 
					SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		return serialPort;
	}

	public static String login(Scanner s) {
		System.out.println("-----------------");
		System.out.println("����ƮȨ ���� �α���");
		System.out.println("-----------------");
		System.out.print("ID: ");
		String id = s.next();
		System.out.print("PW: ");
		String passwd = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && 
			passwd.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else if (id.equals(GUEST_ID) && 
			passwd.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}
	
	public static int adminMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("����ƮȨ ���� ������");
		System.out.println("------------------");
		System.out.println("1.TV �ѱ�");
		System.out.println("2.TV ����");
		System.out.println("3.���Ϸ� ����");
		System.out.println("4.��Ź�� ����");
		System.out.println("5.��� ����");
		System.out.println("6.�α׾ƿ�");
		System.out.println("7.����");
		System.out.println("------------------");
		System.out.print("�޴� ����: ");
		return s.nextInt();
	}
	
	public static int guestMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("����ƮȨ ���� �����");
		System.out.println("------------------");
		System.out.println("1.TV �ѱ�");
		System.out.println("2.TV ����");
		System.out.println("3.���Ϸ� ����");
		System.out.println("4.��Ź�� ����");
		System.out.println("5.�α� �ƿ�");
		System.out.println("6.����");
		System.out.println("------------------");
		System.out.print("�޴� ����: ");
		return s.nextInt();
	}
	
	public static boolean adminWork(Scanner s, 
		SerialPort serial) {
		switch (adminMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV �ѱ�");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV ����");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("���Ϸ� ����");
			try {
				serial.writeInt(CMD_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("��Ź�� ����");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_EMARGENCY:
			System.out.println("��� ����");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_ADMIN_LOGOUT:
			System.out.println("������ �α� �ƿ�");
			return false;
		case MENU_ADMIN_EXIT:
			System.out.println("���α׷� ����");
			s.close();
			System.exit(0);
		}
		return true;
	}
	
	public static boolean guestWork(Scanner s, 
			SerialPort serial) {
		switch (guestMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV �ѱ�");
			break;
		case MENU_TV_OFF:
			System.out.println("TV ����");
			break;
		case MENU_HEATER_ON:
			System.out.println("���Ϸ� ����");
			break;
		case MENU_CLEANER_ON:
			System.out.println("��Ź�� ����");
			break;
		case MENU_GUEST_LOGOUT:
			System.out.println("����� �α� �ƿ�");
			return false;
		case MENU_GUEST_EXIT:
			System.out.println("���α׷� ����");
			s.close();
			System.exit(0);
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
					if (adminWork(s, serial)==false) {
						break;
					}
				}
			}
			else if (mode.equals(GUEST_MODE)) {
				while (true) {
					if (!guestWork(s, serial)) {
						break;
					}
				}
			}
			else {
				System.out.println("ID �Ǵ� ����� �߸��Ǿ����ϴ�.");
				System.out.println("�ٽ� �Է��ϼ���.");
			}
		}
	}

}



