package com.hcs.carApp.customer;

import com.hcs.carApp.car.Car;

public class Customer {
	private String name;
	private String tel;
	private String address;
	private Car car;
	

	public Customer(String name, String tel, String address, Car car) {
		super();
		this.name = name;
		this.tel = tel;
		this.address = address;
		this.car = car;
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

	public Car getCar() {
		return car;
	}

	public void setCar(Car car) {
		this.car = car;
	}

	public void printCustomerInfo() {
		System.out.println("고객 이름 : " + name);
		System.out.println("고객 전화 : " + tel);
		System.out.println("고객 주소 : " + address);
		car.printCarInfo();
		System.out.println("---------------------------");
	}
}
