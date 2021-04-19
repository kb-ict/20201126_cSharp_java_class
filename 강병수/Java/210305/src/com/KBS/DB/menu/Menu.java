package com.KBS.DB.menu;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

import com.KBS.DB.model.AddressBook;

public class Menu {
	
	public static final int TABLE_CREATE = 1;
	public static final int TABLE_DELETE = 2;
	public static final int DATA_CREATE = 3;
	public static final int SAMPLE_DATA = 4;
	public static final int DATA_READ = 5;
	public static final int DATA_MODIFY = 6;
	public static final int DATA_DELETE = 7;
	public static final int PROGRAM_EXIT = 8;
	
	public int mainMenu(Scanner sc) {
		System.out.println("=================");
		System.out.println("  MySQL DB 관리");
		System.out.println("=================");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 샘플 데이터 추가");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 프로그램 종료");
		System.out.println("=================");
		System.out.print("메뉴 번호 입력: ");
		return sc.nextInt();
	}
	
	public AddressBook addMenu(Scanner sc) {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		System.out.println("=================");
		System.out.println("  데이터 추가 메뉴");
		System.out.println("=================");
		System.out.print("이름: ");
		String name = sc.next();
		System.out.print("나이: ");
		int age = sc.nextInt();
		System.out.print("전화: ");
		String tel = sc.next();
		System.out.print("주소: ");
		String address = null;
		try {
			address = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print("이메일: ");
		String email = sc.next();
		return new AddressBook(name, age, tel, address, email);
	}
}
