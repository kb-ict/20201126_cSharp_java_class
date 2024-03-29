package com.lg.carapp.car;

public class Car {
	private String model;
	private int year;
	private String money;
		
	public Car() {
		System.out.println("Car()");
	}
	public Car(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}
	
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
		System.out.println(model);
		System.out.println(year);
		System.out.println(money);
	}
	
}
