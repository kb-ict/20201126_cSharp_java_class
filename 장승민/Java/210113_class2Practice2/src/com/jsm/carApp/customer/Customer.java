package com.jsm.carApp.customer;

import com.jsm.carApp.car.Car;

public class Customer {
	private String name;
	private String tel;
	private String address;
	private Car car;
	private static Customer inst;
	
	public static Customer getInstance(String name, String tel, String address, Car car) {
		if(inst==null) {
			inst=new Customer(name, tel, address, car);
		}
		return inst;
	}
	
	
	public Customer(String name, String tel, String address, Car car) {
		super();
		this.name = name;
		this.tel = tel;
		this.address = address;
		this.car = car;
	}




	public void printCustomerInfo() {
		System.out.println("고객명 :"+name);
		System.out.println("전화번호 :"+tel);
		System.out.println("주소 :"+address);
		car.printCarInfo();
	}
	
}
