package serial0217;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Arduino extends Thread {
	public static final char TV_ON = '1';
	public static final char TV_OFF = '2';
	public static final char HOTTER_ON = '3';
	public static final char CLEANER_ON = '4';
	public static final char LOGOUT = '5';
	public static final char PROGRAM_EXIT = '6';
	public static final char ADMIN_SETTING = '7';
	private boolean isAdmin;
	private static SerialPort serialPort = null;
	public static SerialPort getSerialPortInstance() {
		if(serialPort == null) {
			// SerialPort 열기 !!
			String[] portName = SerialPortList.getPortNames();
			serialPort = new SerialPort(portName[0]);
			try {
				serialPort.openPort();
				serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}
		
		return serialPort;
	}
	public Arduino(boolean isAdmin) {
		this.isAdmin = isAdmin;
	}
	private void showMenuList() {
		System.out.println("--------------------------------------");
		System.out.println("          스마트 홈 제어 v1.0");
		System.out.println("--------------------------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 로그아웃 >_< ~!!");
		System.out.println("6. 프로그램 종료");
		if(isAdmin)
			System.out.println("7. 관리자 특별 모드 >_< ~!!");
		System.out.println("--------------------------------------");
	}





	@Override
	public void run() {

		// SerialPort 열기 !!
		Arduino.getSerialPortInstance();

		// 아두이노가 보내는 디버그 메세지를 받을려고 한당 !!
		new Thread(new ReadThread(serialPort)).start();

		// 나는 이제부터, 사용자가 아두이노로 보내는 메세지를 듣고 전달하는 역할을 해야지
		showMenuList();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		try {
			while (true) {
				char select = br.readLine().charAt(0);
				switch(select) {
				case Arduino.LOGOUT:
					System.out.println("로그아웃 !!");
					return;
				case Arduino.PROGRAM_EXIT:
					System.out.println("프로그램 종료");
					System.exit(0);
					break;
				case Arduino.ADMIN_SETTING:
					if(!isAdmin)
						break;
					System.out.println("사실 미구현이야 ~_~ 관리자기능 없어");
					break;
				default:
					serialPort.writeInt(select);
					break;
				}
			}
		} catch (IOException e) {
			e.printStackTrace();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
}

class ReadThread implements Runnable {
	SerialPort serial;
	public ReadThread(SerialPort serial) {
		this.serial = serial;
	}

	@Override
	public void run() {
		while (true) {
			try {
				byte[] read = serial.readBytes();
				if (read != null && read.length > 0) {
					System.out.print(new String(read));
				}
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}

	}
}