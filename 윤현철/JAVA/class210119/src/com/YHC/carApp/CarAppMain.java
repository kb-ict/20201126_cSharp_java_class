package com.YHC.carApp;

import java.util.Random;

import com.YHC.carApp.car.Car;
import com.YHC.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[]= {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String tel[]= {"010-1234-5678","010-4321-5678","010-3478-1278","010-4523-1978","010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		String model[]= {"SM6","쏘나타","싼타페","K7","그렌져"};
		String color[]= {"블랙","은색","흰색","회색","빨강"};
		int year[]= {2016,2017,2016,2017,2016};
		String company[]= {"삼성르노","현대","현대","기아","현대"};
		String price[]= {"삼천만원","삼천이백만원","삼천육백만원","삼천사백만원","사천만원"};
		Random r = new Random();
		Customer cu[]= new Customer[10];
		for (int i = 0; i < cu.length; i++) {
			int a = r.nextInt(5);
			cu[i]=new Customer(name[r.nextInt(5)],tel[r.nextInt(5)],address[r.nextInt(5)],new Car(model[a],color[a],year[a],company[a],price[a]));
			cu[i].printCustomerInfo();
		}
	}

}
