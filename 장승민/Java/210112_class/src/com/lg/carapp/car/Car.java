package com.lg.carapp.car;

public class Car {
//	차에 대한 특징 뽑아냄 -> 추상화
	private String model;
	private int year;
	private String money;

// 클래스 정보 초기화
	public Car() {
		model = "K7";
		year = 2020;
		money = "4천만원";
		System.out.println("기본 생성자 생성!");
		showCarInfo();
	}
	// 오버로딩 (중복 정의)
	//1. 매개변수 개수 다름.
	//2. 매개변수 타입 다름. 
	public Car(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}

	// getter & setter 생성 source 탭 "Generate Getters and Setters..." click
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}

	public String getMoney() {
		return money;
	}

	public void setMoney(String money) {
		this.money = money;
	}

	public void showCarInfo() {
		System.out.println("모델 명 : " + model);
		System.out.println("연식 : " + year);
		System.out.println("금액 : " + money);
		System.out.println("-----------------");

	}

}
