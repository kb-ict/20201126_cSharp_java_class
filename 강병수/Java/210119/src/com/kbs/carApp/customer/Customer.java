package com.kbs.carApp.customer;

public class Customer {
	
	private String name;
	private String tel;
	private String address;
	private static Customer inst;
	
	public static Customer getInstance(String name, String tel, String address) {
		if (inst == null) {
			inst = new Customer(name, tel, address);
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

	public Customer(String name, String tel, String address) {
		this.name = name;
		this.tel = tel;
		this.address = address;
	}
	
	public void printCustomerInfo() {
		System.out.println("이름: " + name);
		System.out.println("전화번호: " + tel);
		System.out.println("주소: " + address);
	}
	
}
