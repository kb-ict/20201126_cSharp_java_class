package com.sec_samDab2_2.carApp.car;

public class Car {
	private String model;
	private int year;
	private String color;
	private String company;
	private String price;

	// 매개변수를 사용하는 생성자
	public Car(String model, int year, String color, String company, String price) {
		super();
		this.model = model;
		this.year = year;
		this.color = color;
		this.company = company;
		this.price = price;
	}

	// getter / setter
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

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getCompany() {
		return company;
	}

	public void setCompany(String company) {
		this.company = company;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public void printCarInfo() {
		System.out.println("제조사\t: " + company);
		System.out.println("모델\t: " + model);
		System.out.println("색상\t: " + color);
		System.out.println("가격\t: " + price);
		System.out.println("연식\t: " + year);
	}

}
