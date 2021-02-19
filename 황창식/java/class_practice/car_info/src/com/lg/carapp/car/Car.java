package com.lg.carapp.car;

public class Car {
//	static String deri = "동대구 영업소";
//	private String madeCom;
//	private String color;
//	private String model;
//	private String price;
//
//
//	public Car() {
//		madeCom = "기아";
//		model = "K7";
//		price = "4천만원";
//		color = "블랙";
//	}
//
//	public String getMadeCom() {
//		return madeCom;
//	}
//
//	public void setMadeCom(String madeCom) {
//		this.madeCom = madeCom;
//	}
//
//	public String getColor() {
//		return color;
//	}
//
//	public void setColor(String color) {
//		this.color = color;
//	}
//
//	public String getModel() {
//		return model;
//	}
//
//	public void setModel(String model) {
//		this.model = model;
//	}
//
//	public String getPrice() {
//		return price;
//	}
//
//	public void setPrice(String price) {
//		this.price = price;
//	}
//	
//	
//
//	public Car(String madeCom, String color, String model, String price) {
//		super();
//		this.madeCom = madeCom;
//		this.color = color;
//		this.model = model;
//		this.price = price;
//	}
//
//	public void showCarInfo() {
//		System.out.println("제조사 : " + madeCom);
//		System.out.println("색상 : " + color);
//		System.out.println("모델 : " + model);
//		System.out.println("가격 : " + price);
//		System.out.println("대리점명 : " + deri);
//		System.out.println("-------------------");
//	}
	
	public static final String JIJUM = "동대구 영업소";
	private String model;
	private String company;
	private String color;
	private String price;
	
	public Car() {
		model = "K7";
		company = "기아";
		color = "블랙";
		price = "사천만원";
	}

	public Car(String model, String company, String color, String price) {
		super();
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}
	
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public void showCarInfo() {
		System.out.println("제조사	: " + company);
		System.out.println("모델명	: " + model);
		System.out.println("색상	: " + color);
		System.out.println("가격	: " + price);
		System.out.println("대리점명 : " + JIJUM);
		System.out.println("---------------------------");
	}
}
