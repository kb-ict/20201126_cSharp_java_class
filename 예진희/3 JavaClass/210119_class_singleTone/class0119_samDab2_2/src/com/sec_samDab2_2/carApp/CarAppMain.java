package com.sec_samDab2_2.carApp;

import java.util.Random;

import com.sec_samDab2_2.carApp.car.Car;
import com.sec_samDab2_2.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		String tel[] = { "010-1234-5678", "010-1234-1235", "010-1234-1236", "010-1234-1237", "010-1234-1238" };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

		String model[] = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
		String color[] = { "블랙", "은색", "흰색", "회색", "빨강" };
		int year[] = { 2021, 2020, 2019, 2018, 2017 };
		String company[] = { "르노삼성", "현대", "현대", "기아", "쌍용", "GM" };
		String price[] = { "2천 오백만원", "3천만원", "3천 오백만원", "4천만원", "4천 오백만원" };
		// 객체지향: 클래스 재사용, 필요한거 당겨쓰려고..

		Random r = new Random();
		Customer sc[] = new Customer[10];
		for (int i = 0; i < sc.length; i++) {
			System.out.printf("%d번째 고객 ---------------- \n", (i+1));
			sc[i] = new Customer(name[r.nextInt(5)], tel[r.nextInt(5)], address[r.nextInt(5)],
					new Car(model[r.nextInt(5)], year[r.nextInt(5)], color[r.nextInt(5)], company[r.nextInt(6)],
							price[r.nextInt(5)]));
			sc[i].printCustomerInfo();
		}

	}
}
