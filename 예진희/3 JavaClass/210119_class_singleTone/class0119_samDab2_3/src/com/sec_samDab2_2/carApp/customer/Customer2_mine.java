package com.sec_samDab2_2.carApp.customer;

import java.util.Random;

import com.sec_samDab2_2.carApp.car.Car;

public class Customer2_mine {
	private String name;
	private String tel;
	private String address;
	private Car car;
	// 만든 클래스 불러 옴, 많이쓰는 형식, 다른패키지에 있음 import
	// 고객 객체생성 생성시 차 객체도 같이 생성

	static Random r = new Random();
	private static Customer2_mine inst; // 싱글톤, 자기 자신의 타입

	// 매개변수 사용하는 생성자
	public Customer2_mine(String name, String tel, String address, Car car) {
		super();
		this.name = name;
		this.tel = tel;
		this.address = address;
		this.car = car;
	}

	public static Customer2_mine getInstance(String name, String tel, String address, Car car) {
		if (inst == null) {
			inst = new Customer2_mine(name, tel, address, car);
		}
		return inst;
	}

	// getter / setter
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
		System.out.println("고객명\t: " + name);
		System.out.println("전화\t: " + tel);
		System.out.println("주소\t: " + address);
		car.printCarInfo();
		System.out.println("--------------------------\n");
	}
}
