package com.lg.carapp;

import com.lg.carapp.car.Car;

public class Main {
	public static void main(String[] args) {
//		Car car1 = new Car();
//		car1.setMadeCom("현대");
//		car1.setModel("소나타");
//		car1.setColor("실버");
//		car1.setPrice("3천만원");
//		car1.showCarInfo();
//		
//		Car car2 = new Car("쉐보레", "옐로우", "카마로", "1억8천만원");
//		car2.showCarInfo();
		
		Car car = new Car();
		car.showCarInfo();
		
		Car car2 = new Car("그랜저", "현대", "흰색", "삼천만원");
		car2.showCarInfo();
	}

}
