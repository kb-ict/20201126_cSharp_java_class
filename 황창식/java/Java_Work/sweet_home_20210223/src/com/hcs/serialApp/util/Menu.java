package com.hcs.serialApp.util;
import java.util.Scanner;

import com.hcs.serialApp.handler.SerialCtrl;

import jssc.SerialPort;
public class Menu {
	private static final int LOG_OUT = 5;
	
	private static final String ADMIN_ID = "admin";
	private static final String ADMIN_PW = "1234";

	private static final String GUEST_ID = "guest";
	private static final String GUEST_PW = "5678";

	private final String ADMIN_MODE = "admin_mode";
	private final String GUEST_MODE = "guest_mode";
	
	SerialCtrl controller;
	
	Scanner s;
	
	public String getADMIN_MODE() {
		return ADMIN_MODE;
	}

	public String getGUEST_MODE() {
		return GUEST_MODE;
	}
	
	public Menu(SerialPort serial, Scanner s) {
		controller = new SerialCtrl(serial);
		this.s = s;
	}

	// 로그인 메뉴
	public String login() {
		while (true) {
			System.out.println();
			System.out.println("--------------");
			System.out.println("    Log In");
			System.out.println("--------------");
			System.out.print("  ID : ");
			String id = s.next();
			System.out.print("  PW : ");
			String password = s.next();
			if (id.equals(ADMIN_ID)) {
				if (password.equals(ADMIN_PW)) {
					System.out.println("\n로그인 성공~!");
					return ADMIN_MODE;
				}
				// admin 비밀번호가 틀렸을때
				else {
					System.out.println("\nID 또는 비밀번호가 잘못되었습니다");
				}
					
			} else if (id.equals(GUEST_ID)) {
				if (password.equals(GUEST_PW)) {
					System.out.println("\n로그인 성공~!");
					return GUEST_MODE;
				}
				// guest 비밀번호가 틀렸을때
				else {
					System.out.println("\nID 또는 비밀번호가 잘못되었습니다");
				}
					
			} 
			// 로그인 정보가 틀렸을때
			else {
				System.out.println("\n사용자 정보를 찾을 수 없습니다.");
			}
		}
	}
	
	// 관리자 메뉴
	public void adminMenu() {
		while(true) {
			System.out.println();
			System.out.println("----------------------");
			System.out.println(" 스위트홈 제어 관리자 모드");
			System.out.println("----------------------");
			System.out.println("   1. TV 켜기");
			System.out.println("   2. TV 끄기");
			System.out.println("   3. 보일러 동작");
			System.out.println("   4. 세탁기 동작");
			System.out.println("   5. 로그아웃");
			System.out.println("   6. 포트 연결 해지");
			System.out.println("   7. 포트 재연결");
			System.out.println("   8. 프로그램 종료");
			System.out.println("-------------------------");
			System.out.print("   메뉴 선택 : ");
			int menu = s.nextInt();
			// 로그아웃시 로그인 화면을 돌아감
			if(menu == LOG_OUT) {
				System.out.println("\nLOG OUT!");
				return;
			}
			// 1~4까지의 메뉴는 공통메뉴
			else if(menu > 0 && menu < 5)
				controller.commonWork(menu);
			// 관리자 메뉴 살행
			else if(menu > 5)
				controller.adminWork(menu);
		}
	}
	
	// 사용자 메뉴
	public void guestMenu() {
		while(true) {
			System.out.println();
			System.out.println("----------------");
			System.out.println(" 스위트홈 제어 모드");
			System.out.println("----------------");
			System.out.println("   1. TV 켜기");
			System.out.println("   2. TV 끄기");
			System.out.println("   3. 보일러 동작");
			System.out.println("   4. 세탁기 동작");
			System.out.println("   5. 로그아웃");
			System.out.println("   6. 프로그램 종료");
			System.out.println("-------------------");
			System.out.print("   메뉴 선택 : ");
			int menu = s.nextInt();
			// 로그아웃시 로그인 화면을 돌아감
			if(menu == LOG_OUT) {
				System.out.println("\nLOG OUT!");
				return;
			}
			// 1~4까지의 메뉴는 공통메뉴
			else if(menu > 0 && menu < 5)
				controller.commonWork(menu);
			// 사용자 메뉴 실행
			else if(menu > 5)
				controller.guestWork(menu);
		}
	}
}
