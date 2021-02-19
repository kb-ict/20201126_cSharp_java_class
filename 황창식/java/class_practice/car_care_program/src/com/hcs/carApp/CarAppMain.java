package com.hcs.carApp;

import com.hcs.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {

		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		String model[] = {"SM619", "소나타", "싹다패", "K-7", "그랬져"};
		String color[] = {"블랙", "은색", "흰색", "회색", "빨강"};
		int year[] = {2016, 2017, 2018, 2019, 2020};
		String company[] = {"삼성모르노", "헌대", "기야", "BWM", "Benth"};
		
		Customer cs[] = new Customer[10];
		for (int i = 0; i < cs.length; i++) {
			cs[i] = new Customer(
					model[(int)(Math.random()*5)], 
					color[(int)(Math.random()*5)], 
					year[(int)(Math.random()*5)], 
					company[(int)(Math.random()*5)], 
					name[(int)(Math.random()*5)], 
					tel[(int)(Math.random()*5)], 
					address[(int)(Math.random()*5)]);
			cs[i].printCustomerInfo();
		}
		
		
	}

}
