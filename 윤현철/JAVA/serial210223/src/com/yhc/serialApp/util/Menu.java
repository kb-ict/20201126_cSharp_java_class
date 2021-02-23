package com.yhc.serialApp.util;

import java.util.Scanner;

public class Menu {
	public static int adminMenu(Scanner s) {
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
	
	public static int guestMenu(Scanner s) {
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
	
}
