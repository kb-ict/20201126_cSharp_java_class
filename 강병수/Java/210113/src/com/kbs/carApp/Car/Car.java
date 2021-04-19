package com.kbs.carApp.Car;

public class Car {

	private String model;
	private String color;
	private int year;
	private String company;
	
	public Car(String model, String color, int year, String company) {
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
		System.out.println("모델: " + model);
		System.out.println("색상: " + color);
		System.out.println("연식: " + year);
		System.out.println("제조사: " + company);
	}
	
	
	
	
}
