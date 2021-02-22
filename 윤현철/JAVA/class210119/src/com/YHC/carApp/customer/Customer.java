package com.YHC.carApp.customer;

import com.YHC.carApp.car.Car;

public class Customer {
	private String name;
	private String tel;
	private String address;
	private Car car;
	public Customer(String name, String tel, String address,Car car) {
		super();
		this.name = name;
		this.tel = tel;
		this.address = address;
		this.car=car;
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
		System.out.println("고객명	: "+ name);
		System.out.println("전화	: "+tel);
		System.out.println("주소	: "+address);
		car.printCarInfo();
	}
	
}
