package com.hcs.carApp.customer;

import com.hcs.carApp.car.Car;

public class Customer extends Car {
	private String name;
	private String tel;
	private String address;
		
	public Customer(String model, String color, int year, String company, String name, String tel, String address) {
		super(model, color, year, company);
		this.name = name;
		this.tel = tel;
		this.address = address;
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
		System.out.println("고객 이름 : " + getName());
		System.out.println("고객 전화번호 : " + getTel());
		System.out.println("고객 주소 : " + getAddress());
		System.out.println("모델명 : " + getModel());
		System.out.println("색상 : " + getColor());
		System.out.println("연식 : " + getYear());
		System.out.println("제조사 : " + getCompany());
		System.out.println("-------------------------------");
	}
}
