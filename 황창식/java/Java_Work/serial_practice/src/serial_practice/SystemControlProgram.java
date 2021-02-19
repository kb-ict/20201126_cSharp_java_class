package serial_practice;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SystemControlProgram {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int BOILER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;
	static SerialPort serialPort;
	
	static final char CMD_TV_ON = '1';
	static final char CMD_TV_OFF = '2';
	static final char CMD_BOILER_ON = '3';
	static final char CMD_CLEANER_ON = '4';
	
	// 메뉴 입력
	public static int getMenu(Scanner s) {
		System.out.println("-------------------------");
		System.out.println("   스마트 홈 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("   1. TV 켜기");
		System.out.println("   2. TV 끄기");
		System.out.println("   3. 보일러 동작");
		System.out.println("   4. 세틱기 동작");
		System.out.println("   5. 프로그램 종료");
		System.out.println("-------------------------");
		System.out.print("   메뉴 선택 : ");
		return s.nextInt();
	}
	
	// 시리얼 포트 연결
	public static void getSerialPort() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		serialPort = new SerialPort(portNames[0]);
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		getSerialPort();
		Scanner s = new Scanner(System.in);
		while(true) {
			switch(getMenu(s)) {
			case TV_ON :
				System.out.println("TV ON!");
				try {
					serialPort.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case TV_OFF :
				System.out.println("TV OFF!");
				try {
					serialPort.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case BOILER_ON :
				System.out.println("BOILER ON!");
				try {
					serialPort.writeInt(CMD_BOILER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case CLEANER_ON :
				System.out.println("CLEANER ON!");
				try {
					serialPort.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case PROGRAM_EXIT :
				System.out.println("BYE!");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}