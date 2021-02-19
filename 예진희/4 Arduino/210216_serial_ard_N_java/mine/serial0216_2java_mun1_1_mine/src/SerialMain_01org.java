
import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain_01org {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOT_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;
	static String line = "---------------------";

	public static void main(String[] args) {
		// --------------- 시스템 제어 프로그램 ---------------
		// 1. TV켜기 LED ON
		// 2. TV끄기 LED OFF
		// 3. 보일러 동작 BUZZER
		// 4. 세탁기 동작 SERVO
		// 5. 프로그램 종료
		// 선택메뉴 : 1

		// 가전 제어 : Relay 220V

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

		Scanner s = new Scanner(System.in);
		
		while (true) {
			// System.out.printf("%s\n스마트 홈 제어\n%s\n",line,line);

			switch (getMenu(s)) {
			case TV_ON:
				System.out.println("TV ON");
				break;

			case TV_OFF:
				System.out.println("TV OFF");
				break;

			case HOT_ON:
				System.out.println("보일러 가동");
				break;

			case CLEANER_ON:
				System.out.println("세탁기 가동");
				break;

			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
	
	public static int getMenu(Scanner s) {
		System.out.println("\n" + line);
		System.out.println("   스마트 홈 제어 v1.0+++");
		System.out.println(line);
		System.out.println("  1. TV켜기");
		System.out.println("  2. TV끄기");
		System.out.println("  3. 보일러 동작");
		System.out.println("  4. 세탁기 동작");
		System.out.println("  5. 프로그램 종료");
		System.out.println(line);
		System.out.println("  선택메뉴 : ");
//		int menu = s.nextInt();
//		return menu;
		
		return s.nextInt();
	}
}
