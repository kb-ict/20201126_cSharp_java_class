package com.hcs.serialApp.handler;

import jssc.SerialPort;
import jssc.SerialPortException;

public class SerialCtrl {
	private static final int TV_ON = 1;
	private static final int TV_OFF = 2;
	private static final int BOILER_ON = 3;
	private static final int CLEANER_ON = 4;
	
	private static final char CMD_TV_ON = '1';
	private static final char CMD_TV_OFF = '2';
	private static final char CMD_BOILER_ON = '3';
	private static final char CMD_CLEANER_ON = '4';

	private static final int ADMIN_EMERGANCY_EXIT = 6;
	private static final int ADMIN_RECONNECT = 7;
	private static final int ADMIN_PROGRAM_EXIT = 8;

	private static final int GUEST_PROGRAM_EXIT = 6;

	private SerialPort serial;

	public SerialCtrl(SerialPort serial) {
		this.serial = serial;
	}
	
	// 라이트 켜기 실행
	public void tvOn() {
		if (serial.isOpened()) {
			System.out.println("\nTV ON!");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		} else {
			System.out.println("\n포트가 연결되어 있지 않습니다.");
		}
	}
	
	// 라이트 끄기 실행
	public void tvOff() {
		if (serial.isOpened()) {
			System.out.println("\nTV OFF!");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		} else {
			System.out.println("\n포트가 연결되어 있지 않습니다.");
		}
	}
	
	// 부저 켜기 실행
	public void boilerOn() {
		if (serial.isOpened()) {
			System.out.println("\nBOILER ON!");
			try {
				serial.writeInt(CMD_BOILER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		} else {
			System.out.println("\n포트가 연결되어 있지 않습니다.");
		}
	}
	
	// 서보모터 켜기 실행
	public void cleanerOn() {
		if (serial.isOpened()) {
			System.out.println("\nCLEANER ON!");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		} else {
			System.out.println("\n포트가 연결되어 있지 않습니다.");
		}
	}
	
	// 포트 연결 해지 실행
	public void emerExit() {
		if (!serial.isOpened()) {
			System.out.println("\n포트가 이미 연결해지 되어 있습니다.");
		} else {
			System.out.println("\n" + serial.getPortName() + " DETATCHED!");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}
	}
	
	// 포트 재연결 실행
	public void reconnect() {
		if (serial.isOpened()) {
			System.out.println("\n포트가 연결되어 있습니다.");
		} else {
			try {
				serial.openPort();
				serial.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
						SerialPort.PARITY_NONE);
				System.out.println("\n" + serial.getPortName() + " RECONNECTED");
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}
	}
	
	// 관리자 실행 메뉴
	public void adminWork(int num) {
		switch (num) {
		case ADMIN_EMERGANCY_EXIT:
			emerExit();
			break;
		case ADMIN_RECONNECT:
			reconnect();
			break;
		case ADMIN_PROGRAM_EXIT:
			System.out.println();
			System.out.println("-------------------------");
			System.out.println("BYE!");
			System.exit(0);
		default:
			System.out.println();
			System.out.println("-------------------------");
			System.out.println("잘못 입력하셨습니다.");
		}
	}

	// 사용자 실행 메뉴
	public void guestWork(int num) {
		switch (num) {
		case GUEST_PROGRAM_EXIT:
			System.out.println();
			System.out.println("-------------------------");
			System.out.println("BYE!");
			System.exit(0);
		default:
			System.out.println();
			System.out.println("-------------------------");
			System.out.println("잘못 입력하셨습니다.");
		}
	}
	
	// 공통 실행 메뉴
	public void commonWork(int num) {
		if(num >= 1 && num <= 4) {
			switch(num) {
			case TV_ON:
				tvOn();
				break;
			case TV_OFF:
				tvOff();
				break;
			case BOILER_ON:
				boilerOn();
				break;
			case CLEANER_ON:
				cleanerOn();
				break;
			}
		}
	}
}
