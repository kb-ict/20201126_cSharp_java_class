package com.KBS.DB.menu;

import java.util.Random;

import com.KBS.DB.model.AddressBook;

public class RandData {
	static String[] name = {"홍길동", "고길동", "김길동", "박길동", "이길동"};
	static int[] age = {100, 200, 300 ,400, 500};
	static String[] tel = {"010-1234-1111", "010-1111-1234", "010-5873-1218", "010-5987-1238", "010-4628-1675"};
	static String[] address = {"대구광역시", "인천광역시", "제주자치도", "서울특별시", "부산광역시"};
	static String[] email = {"hong@gmail.com", "go@gmail.com", "kim@gmail.com", "park@gmail.com", "lee@gmail.com"};
	
	Random r = new Random();
	
	public String getRName() {
		return name[r.nextInt(5)];
	}
	
	public int getRAge() {
		return age[r.nextInt(5)];
	}
	
	public String getRTel() {
		return tel[r.nextInt(5)];
	}
	
	public String getRAddress() {
		return address[r.nextInt(5)];
	}
	
	public String getREmail() {
		return email[r.nextInt(5)];
	}
	
	public AddressBook getABook() {
		return new AddressBook(getRName(), getRAge(), getRTel(), getRAddress(), getREmail());
	}
}

