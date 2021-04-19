import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Smart {
	static final int TV_OFF = 1;
	static final int TV_ON = 2;
	static final int BOILER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		SerialPort serial = initSerial();
		while (true) {
			switch (control(sc)) {
			case TV_ON:
				System.out.println("TV 켜기");
				try {
					serial.writeInt(TV_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV 끄기");
				try {
					serial.writeInt(TV_OFF);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case BOILER_ON:
				System.out.println("보일러 작동");
				try {
					serial.writeInt(BOILER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case CLEANER_ON:
				System.out.println("세탁기 작동");
				try {
					serial.writeInt(CLEANER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				try {
					serial.writeInt(5);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
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
		//int menu = sc.nextInt();
		//return menu;
		return sc.nextInt();

	}
	
	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);
		
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
}