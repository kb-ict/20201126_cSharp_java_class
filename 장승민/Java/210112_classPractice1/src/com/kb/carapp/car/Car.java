package com.kb.carapp.car;

public class Car {
	private String maker;
	private String color;
	private String model;
	private String money;
	
	public static String store = "동대구 영업소";
	
	public Car() {
		maker = "기아";
		color="블랙";
		model = "K7";
		money = "4천만원";
	}
	
	

	public String getMaker() {
		return maker;
	}



	public void setMaker(String maker) {
		this.maker = maker;
	}



	public String getColor() {
		return color;
	}



	public void setColor(String color) {
		this.color = color;
	}



	public String getModel() {
		return model;
	}



	public void setModel(String model) {
		this.model = model;
	}



	public String getMoney() {
		return money;
	}



	public void setMoney(String money) {
		this.money = money;
	}



	public Car(String maker, String color, String model, String money) {
		super();
		this.maker = maker;
		this.color = color;
		this.model = model;
		this.money = money;
	}
	
	public void showCarInfo() {
		System.out.println("제조사 : " + maker);
		System.out.println("색상 : " + color);
		System.out.println("모델 이름 : " + model);
		System.out.println("가격 : " + money);
		System.out.println(store);
		System.out.println("--------------------");
	}
	
}
