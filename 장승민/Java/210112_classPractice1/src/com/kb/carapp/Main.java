package com.kb.carapp;

import com.kb.carapp.car.Car;

public class Main {

	public static void main(String[] args) {
		Car car = new Car();
		car.showCarInfo();
		
		car.setMaker("현대");
		car.setColor("화이트");
		car.setModel("코나");
		car.setMoney("2천5백만원");
		
		car.showCarInfo();
		
		Car car2 = new Car("현대", "블랙", "그랜저", "3천만원");
		car2.showCarInfo();
		
		Car car3 = new Car("현asdf대", "블asdf랙", "그asdf랜저", "3천asdf만원");
		car3.showCarInfo();
				
		
	}

	

}
