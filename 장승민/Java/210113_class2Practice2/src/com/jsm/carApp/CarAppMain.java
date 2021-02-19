package com.jsm.carApp;

import java.util.ArrayList;
import java.util.Random;

import com.jsm.carApp.car.Car;
import com.jsm.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		String tel[] = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7561-7498" };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		String model[] = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
		String color[] = { "블랙", "은색", "흰색", "회색", "빨강" };
		int year[] = { 2016, 2017, 2018, 2019, 2020 };
		String company[] = { "삼성르노", "현대", "기아", "쉐보레", "포르쉐" };

		Random rd = new Random();

		// 배열

//		Car[] car = new Car[10];
//		
//		for (int i = 0; i < car.length; i++) {
//			car[i] = new Car(model[rd.nextInt(5)], color[rd.nextInt(5)], year[rd.nextInt(5)], company[rd.nextInt(5)]);
//		}
//		Customer[] customer = new Customer[10];
//		for (int i = 0; i < customer.length; i++) {
//			customer[i] = new Customer(name[rd.nextInt(5)], tel[rd.nextInt(5)], address[rd.nextInt(5)],
//					car[rd.nextInt(10)]);
//		}
//		for (int i = 0; i < 10; i++) {
//			customer[i].printCustomerInfo();
//			System.out.println("----------------------");
//		}

		// ArrayList
		ArrayList<Car> listCar = new ArrayList<>();
		for (int i = 0; i < 10; i++) {
			listCar.add(
					new Car(model[rd.nextInt(5)], color[rd.nextInt(5)], year[rd.nextInt(5)], company[rd.nextInt(5)]));
		}
		ArrayList<Customer> listCustomer = new ArrayList<>();
		for (int i = 0; i < 10; i++) {
			listCustomer.add(
					new Customer(name[rd.nextInt(5)], tel[rd.nextInt(5)], address[rd.nextInt(5)], listCar.get(i)));
		}
		for (int i = 0; i < listCustomer.size(); i++) {
			listCustomer.get(i).printCustomerInfo();
			System.out.println("----------------------");
		}
		
		//싱글톤 객체 생성
		System.out.println("--------------------");
		System.out.println("싱글톤 객체 생성");
		System.out.println("--------------------");
		for(int i=0; i<5;i++) {
			
			Customer.getInstance(name[rd.nextInt(5)], tel[rd.nextInt(5)], address[rd.nextInt(5)], new Car(model[rd.nextInt(5)], color[rd.nextInt(5)], year[rd.nextInt(5)], company[rd.nextInt(5)])).printCustomerInfo();
		}
		
		
	}

}
