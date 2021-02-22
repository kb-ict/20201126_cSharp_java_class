package smartHomeSystem;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HOTTER_ON = 3;
	static final int CLEANNER_On = 4;
	static final int PROGRAM_EXIT = 5;
	static Scanner s; 
	static SerialPort serialPort;
		
	public static void main(String[] args) throws SerialPortException {
		s= new Scanner(System.in);
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		serialPort = new SerialPort(portNames[0]);
		
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, 
					SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		
		while (true) {
			showMenuList();
			menu(s.nextInt());
			
		}
		

	}
	
	public static void showMenuList() {
		System.out.println("-------------------------------------------------");
		System.out.println("스마트 홈 제어");
		System.out.println("-------------------------------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.종료");
		System.out.println("-------------------------------------------------");
		System.out.print("메뉴 선택 : ");
	}

	public static void menu(int menu) throws SerialPortException {
		
		switch (menu) {
		case TV_ON:
			System.out.println("TV ON");
			serialPort.writeInt('1');
			break;
		case TV_OFF:
			System.out.println("TV OFF");
			serialPort.writeInt('0');
			break;
		case HOTTER_ON:
			System.out.println("보일러 동작");
			serialPort.writeInt('2');
			break;
		case CLEANNER_On:
			System.out.println("세탁기 동작");
			serialPort.writeInt('3');

			break;
		case PROGRAM_EXIT:
			System.out.println("시스템 종료");
			s.close();
			System.exit(0);
		}
	}
}
