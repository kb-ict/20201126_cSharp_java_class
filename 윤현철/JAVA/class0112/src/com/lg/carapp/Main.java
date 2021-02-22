package com.lg.carapp;

import java.util.ArrayList;

import com.lg.carapp.car.Car;

public class Main {

	public static void main(String[] args) {
		Car car = new Car();
		new Car();
		new Car();
		
//		Car car2 = new Car("그랜저",2021,"3천만원");
//		car2.showCarInfo();
		
		Car car3[]=new Car[10];
//		int num[]= new int[10];
//		car3[0]=new Car();
//		car3[9]=new Car();
		
		
		
//		for (int i = 0; i < car3.length; i++) {
//			car3[i]=new Car();
//		}
		ArrayList<Car> arrList = new ArrayList<>();
		arrList.add(new Car("소나타",2020,"2천만원"));
		arrList.add(new Car("SM7",2021, "3천만원"));
		
		for (int i = 0; i < arrList.size(); i++) {
//			Car mycar = arrList.get(i);
//			mycar.showCarInfo();
			arrList.get(i).showCarInfo();
		}
		
	}

}
