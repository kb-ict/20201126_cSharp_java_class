package com.KBS.serialApp.util;

import java.util.Scanner;

public class Serial_Menu {
	Scanner sc = new Scanner(System.in);

	public int guestMenu(Scanner sc) {
		System.out.println("------------------");
		System.out.println("   스마트 홈 제어");
		System.out.println("------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 종료");
		System.out.println("6. 로그아웃");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		return sc.nextInt();
	}

	public int adminMenu(Scanner sc) {
		System.out.println("--------------------");
		System.out.println("스마트 홈 제어 관리자 모드");
		System.out.println("--------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급 정지");
		System.out.println("6. 재연결");
		System.out.println("7. 종료");
		System.out.println("8. 로그아웃");
		System.out.println("--------------------");
		System.out.print("메뉴 선택: ");
		return sc.nextInt();
	}
}
