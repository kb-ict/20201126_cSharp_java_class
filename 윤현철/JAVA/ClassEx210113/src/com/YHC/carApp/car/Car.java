package com.YHC.carApp.car;

public class Car {
	private String model;
	private String color;
	private int year;
	private String company;
	public Car(String model, String color, int year, String company) {
		super();
		this.model = model;
		this.color = color;
		this.year = year;
		this.company = company;
	}
	
	
	
	public String getModel() {
		return model;
	}



	public void setModel(String model) {
		this.model = model;
	}



	public String getColor() {
		return color;
	}



	public void setColor(String color) {
		this.color = color;
	}



	public int getYear() {
		return year;
	}



	public void setYear(int year) {
		this.year = year;
	}



	public String getCompany() {
		return company;
	}



	public void setCompany(String company) {
		this.company = company;
	}



	public void printCarInfo() {
		System.out.println(model);
		System.out.println(color);
		System.out.println(year);
		System.out.println(company);
		System.out.println("--------------------");
	}
}
