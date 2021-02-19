package com.lg.carapp.car;
//패키지.. 기능별 분류
public class Car {
	private String model;
	private int year;
	private String money;
	
	int arr[] = {10,20,30,40,50}; //밖에서 초기화 가능
	
	// 기본 생성자 = 클래스 정보 초기화
	public Car() {
		model = "K7";
		year = 2020;
		money ="4천만원";
		
		System.out.println("기본 생성자 생성");
		showCarInfo();
	}
	
	// 오버로딩(중복정의 : 1또는 2 해당해야함) 현재: Car메소드가 2개
	/* 조건1. 매개변수 개수 다름.
	 * 조건2. 매개변수 타입이 다름.
	 * 
	 * source > Generate Constructor using field...
	 */
	public Car(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}
	
	// 외부에 값을 getter로 받아와서 인스턴스 변수로 set.
	
	//private 없으면 default 접근-------
	//클래스내 퍼블릭 외부에서 private
	// 외부접근 public
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
		System.out.println("모델: "+model);
		System.out.println("연식: "+year);
		System.out.println("가격: "+money);
		System.out.println("-----------------------");
	}
	

	
	
}
