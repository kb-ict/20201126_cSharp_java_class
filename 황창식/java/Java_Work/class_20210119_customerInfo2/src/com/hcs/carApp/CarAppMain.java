package com.hcs.carApp;

import com.hcs.carApp.car.Car;
import com.hcs.carApp.customer.Customer;

public class CarAppMain {
	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		String model[] = {"SM65", "소나개나타", "싹다패", "K-Car7", "그랬져"};
		String color[] = {"블랙", "은색", "흰색", "회색", "빨강"};
		int year[] = {2016, 2017, 2018, 2019, 2020};
		String company[] = {"삼성모르노?", "근현대", "BWM", "Benth", "시부레"};
		String price[] = {"4천만원", "8천만원", "1억 2천만원", "2억 3천만원", "측정 불가"};
		
		System.out.println("--------------------------");
		System.out.println("인스턴스 객체 생성");
		System.out.println("--------------------------");
		for (int i = 0; i < 10; i++) {
			System.out.println(i+1 + "번 고객 정보");
			new Customer(
					name[(int)(Math.random()*5)],
					tel[(int)(Math.random()*5)],
					address[(int)(Math.random()*5)], 
					new Car(model[(int)(Math.random()*5)],
							color[(int)(Math.random()*5)],
							year[(int)(Math.random()*5)],
							company[(int)(Math.random()*5)],
							price[(int)(Math.random()*5)]))
			.printCustomerInfo();
		}
		
		System.out.println();
		
		System.out.println("--------------------------");
		System.out.println("SingleTone 객체 생성");
		System.out.println("--------------------------");
		for (int i = 0; i < 10; i++) {
			System.out.println(i+1 + "번 고객 정보");
			Customer.getInstance(
					name[(int)(Math.random()*5)],
					tel[(int)(Math.random()*5)],
					address[(int)(Math.random()*5)], 
					new Car(model[(int)(Math.random()*5)],
							color[(int)(Math.random()*5)],
							year[(int)(Math.random()*5)],
							company[(int)(Math.random()*5)],
							price[(int)(Math.random()*5)]))
			.printCustomerInfo();
		}
		
		
	}

}
