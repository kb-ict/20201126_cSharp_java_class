
import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOTTER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HOTTER_ON = '2';
	static final int CMD_CLEANER_ON = '3';

	public static int getMenu(Scanner s) {

		System.out.println("-------------------");
		System.out.println("스마트 홈 제어 v1.0");
		System.out.println("-------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.종료");
		System.out.println("-------------------");
		System.out.print("메뉴 선택: ");

		// return menu;
		return s.nextInt();
	}

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

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		SerialPort serial = initSerial();
		while (true) {
			switch (getMenu(s)) {
			case TV_ON:
				System.out.println("TV_ON");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) { // TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV_OFF");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) { // TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;

			case HOTTER_ON:
				System.out.println("보일러_ON");
				try {
					serial.writeInt(CMD_HOTTER_ON);
				} catch (SerialPortException e) { // TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;

			case CLEANER_ON:
				System.out.println("세탁기_ON");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;

			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);

				break;
			}
		}

	}
}