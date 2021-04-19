package com.kbs.carApp;

import java.util.Random;

import com.kbs.carApp.Car.Car;
import com.kbs.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		String tel[] = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134" };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		String model[] = { "SM6", "쏘나타", "싼타페", "K7", "그랜저" };
		String color[] = { "블랙", "은색", "흰색", "회색", "빨강" };
		int year[] = { 2016, 2017, 2016, 2017, 2016 };
		String company[] = { "삼성르노", "현대", "현대", "기아", "현대" };

		Random r = new Random();
		for (int i = 0; i < 5; i++) {
			System.out.println("번호: " + (i + 1));
			new Customer(name[r.nextInt(5)], tel[r.nextInt(5)], address[r.nextInt(5)])
			.printCustomerInfo();
			new Car(model[r.nextInt(5)], color[r.nextInt(5)], year[r.nextInt(5)], company[r.nextInt(5)])
			.printCarInfo();
			System.out.println("========================");
		}
		
		System.out.println("========================");
		System.out.println("      싱글톤 객체 생성");
		System.out.println("========================");
		for (int i=0; i<3; i++) {
			Customer.getInstance(name[r.nextInt(5)], tel[r.nextInt(5)], address[r.nextInt(5)])
			.printCustomerInfo();;
			Car.getInstance(model[r.nextInt(5)], color[r.nextInt(5)], company[r.nextInt(5)], year[r.nextInt(5)])
			.printCarInfo();;
			
		}


	}

}
