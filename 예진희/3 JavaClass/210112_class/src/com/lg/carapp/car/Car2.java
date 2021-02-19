package com.lg.carapp.car;

// 문제 1 풀이
// 최상위 Object에서 상속받아 사용 Super 부모클래스
public class Car2 {
	
	private String model;
	private String year;
	private String money;
	public static final String jijum = "영업소";
	
	// 기본 생성자 체크해제 
	public Car2() {
		super();
	}

	public Car2(String model, String year, String money) {
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

	public String getYear() {
		return year;
	}

	public void setYear(String year) {
		this.year = year;
	}

	public String getMoney() {
		return money;
	}

	public void setMoney(String money) {
		this.money = money;
	}
	
	public void showCarInfo() {
		System.out.println("모델: "+model);
		System.out.println("연식: "+year);
		System.out.println("가격: "+money);
		System.out.println("------------");
	}

}
