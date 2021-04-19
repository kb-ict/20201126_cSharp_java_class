package com.KBS.serialApp.control;

import jssc.SerialPort;
import jssc.SerialPortException;
import java.util.Scanner;
import com.KBS.serialApp.network.*;
import com.KBS.serialApp.util.*;

public class Serial_Control {

	Scanner sc = new Scanner(System.in);
	//Serial_Network serial = new Serial_Network();
	static Serial_Menu menu = new Serial_Menu();

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

	public static String loginMenu(Scanner sc) {
		System.out.println("------------------");
		System.out.println(" 스마트 홈 제어 로그인");
		System.out.println("------------------");
		System.out.print("ID: ");
		String id = sc.next();
		System.out.print("PW: ");
		String pw = sc.next();
		String mode = "";
		if (id.equals(GUEST_ID) && pw.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else if (id.equals(ADMIN_ID) && pw.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}

	public static boolean guestControl(Scanner sc, SerialPort serial) {
		switch (menu.guestMenu(sc)) {
		case GUEST_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt('1');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt('2');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt('3');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case GUEST_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt('4');
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

	public static boolean adminControl(Scanner sc, SerialPort serial) {
		switch (menu.adminMenu(sc)) {
		case ADMIN_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt('1');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt('2');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt('3');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt('4');
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_EMERGENCY:
			System.out.println("긴급 정지");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case ADMIN_CONNECT:
			System.out.println("통신 재연결");
			if (!serial.isOpened()) {
				Serial_Network.openSerial();
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
}
