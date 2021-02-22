package com.j.carApp;

import java.util.Random;
import com.j.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278",
				"010-4523-1978", "010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동",
				"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		String model[] = {"SM6", "쏘나타", "싼타페", "K7", "그랜져"};
		String color[] = {"블랙", "은색", "흰색", "회색", "빨강"};
		int year[] = {2016, 2017, 2016, 2017, 2016};
		String company[] = {"삼성르노", "현대", "현대", "기아", "현대"};
		
		Customer customer[] = new Customer[10];
		Random rand = new Random();
		
		for (int i = 0; i < customer.length; i++) {
			String _name = name[rand.nextInt(5)];
			String _tel = tel[rand.nextInt(5)];
			String _address = address[rand.nextInt(5)];
			String _model = model[rand.nextInt(5)];
			String _color = color[rand.nextInt(5)];
			int _year = year[rand.nextInt(5)];
			String _company = company[rand.nextInt(5)];
			customer[i] = new Customer(_name, _tel, _address,
					_model, _color, _year, _company);
		}
		
		for (var c : customer) {
			c.printCustomerInfo();
		}
		
		System.out.println("---------------------------");
		
		
	}
	
}
