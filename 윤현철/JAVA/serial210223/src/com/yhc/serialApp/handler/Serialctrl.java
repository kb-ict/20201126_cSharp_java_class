package com.yhc.serialApp.handler;

import java.util.Scanner;

import com.yhc.serialApp.network.Myserial;
import com.yhc.serialApp.util.Menu;

import jssc.SerialPort;
import jssc.SerialPortException;

public class Serialctrl {
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
	public static final int MENU_ADMIN_LOGOUT = 7;
	public static final int MENU_GUEST_EXIT = 6;
	public static final int MENU_ADMIN_RECONN = 6;
	public static final int MENU_ADMIN_EXIT = 8;
	public static final int MENU_EMARGENCY = 5;
	
	static final int CMD_TV_ON 		= '1';
	static final int CMD_TV_OFF 	= '0';
	static final int CMD_HEATER_ON 	= '2';
	static final int CMD_CLEANER_ON = '3';
	
	
	public static String login(Scanner s) {
		System.out.println("-----------------");
		System.out.println("스마트홈 제어 로그인");
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
	
	
	public static boolean adminWork(Scanner s, 
		SerialPort serial) {
		switch (Menu.adminMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(CMD_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_EMARGENCY:
			System.out.println("긴급 정지");
			try {
				serial.writeInt(CMD_TV_OFF);
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_ADMIN_RECONN:
			System.out.println("통신 재연결");
			if (!serial.isOpened()) {
				Myserial.openSerial(serial);
			}
			break;
		case MENU_ADMIN_LOGOUT:
			System.out.println("관리자 로그 아웃");
			return false;
		case MENU_ADMIN_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}
	
	public static boolean guestWork(Scanner s, 
			SerialPort serial) {
		switch (Menu.guestMenu(s)) {
		case MENU_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(CMD_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_CLEANER_ON:
			System.out.println("세탁기 가동");
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case MENU_GUEST_LOGOUT:
			System.out.println("사용자 로그 아웃");
			return false;
		case MENU_GUEST_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}


	
}
