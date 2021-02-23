package com.yjh.serialApp.util;

import java.util.Scanner;

public class Menu {
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";
	private Scanner s;

	public Menu(Scanner s) {
		this.s = s;
	}

	public String login() {
		System.out.println("-----------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("-----------------");
		System.out.print("ID: ");
		String id = s.next();
		System.out.print("PW: ");
		String passwd = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && passwd.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else if (id.equals(GUEST_ID) && passwd.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}

	public int adminMenu() {
		System.out.println("------------------");
		System.out.println("스마트홈 제어 관리자");
		System.out.println("------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.긴급 정지");
		System.out.println("6.통신 재연결");
		System.out.println("7.로그아웃");
		System.out.println("8.종료");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	public int guestMenu() {
		System.out.println("------------------");
		System.out.println("스마트홈 제어 사용자");
		System.out.println("------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.로그 아웃");
		System.out.println("6.종료");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		return s.nextInt();
	}

	public Scanner getS() {
		return s;
	}

	public void setS(Scanner s) {
		this.s = s;
	}

}
