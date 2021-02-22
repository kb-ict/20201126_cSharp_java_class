package com.j.carApp.customer;

import com.j.carApp.car.Car;

public class Customer extends Car{
	private String name;
	private String tel;
	private String address;
	private static Customer inst;
	
	public Customer(String name, String tel, String address,
			String model, String color, int year, String company) {
		super(model, color, year, company);
		this.name = name;
		this.tel = tel;
		this.address = address;
	}
	
	public Customer getInstance(String name, String tel, String address,
			String model, String color, int year, String company) {
		if (inst == null) {
			inst = new Customer(name, tel, address, model, color, year, company);
		}
		return inst;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getTel() {
		return tel;
	}

	public void setTel(String tel) {
		this.tel = tel;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}
	
	public void printCustomerInfo() {
		System.out.println("고객명 : " + name);
		System.out.println("전화번호 : " + tel);
		System.out.println("주소 : " + address);
		printCarInfo();
	}
	
}
