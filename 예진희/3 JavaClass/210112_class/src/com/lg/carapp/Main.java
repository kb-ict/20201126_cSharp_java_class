package com.lg.carapp;

import java.util.ArrayList;

import com.lg.carapp.car.Car;
//패키지 분리로 import, Car(); 생성자 (기본)

public class Main {
	public static void main(String[] args) {
		// 내가 만든 기본생성자가 없으면 자바 컴파일러가 자동으로 생성
		// 내가 만든 기본생성자가 있으면 내가 만든 기본 생성자를 사용
		// 자동생성시 빈 메소드, 생성돼있으면 해당내용 실행
		
		// 1 생성 후 변수가 마킹
		//Car car = new Car();
		//car.setModel("1. 그랜져개조");
		//car.setYear(2020);
		//car.setMoney("3천만원");
		//car.showCarInfo();
		
		// 생성만, 접근 및 재사용 불가능 1 ≠ 2 ≠ 3 ≠ 4
		// 2 new Car();
		// 3 new Car();
		// car.showCarInfo();
		
		// 4 매개변수 존재하는 생성자 사용
		//Car car2 = new Car("2. 그랜저", 2021, "3천만원");
		//car2.showCarInfo();
		
		// 객체생성 X, 카클래스 타입가지는 빈 배열 생성
		// 의 개념 int num[] = new int[10];
		Car car3[] = new Car[2];	// 
		
		// car3[0] = new Car();
		// car3[9] = new Car();
		
		// 배열크기만큼 카객체 생성 및 참조
		//for (int i = 0; i < car3.length; i++) {
		//	System.out.print(i+1+". ");
		//	car3[i] = new Car();
		//}
		
		
		//교재 546페이지
		// 컬렉션 클래스(자료구조에 나오는걸 클래스화 시킨 것) ArrayList
		ArrayList<Car> arrList = new ArrayList<>(); //크기 정해져있지 않은 배열 <여러타입 가능 Int, String...>
		arrList.add(new Car("소나타", 2020, "2천만원")); //List 공간 만들고 집어넣음
		arrList.add(new Car("SM7",2021, "3천만원"));
		
		for (int i = 0; i < arrList.size(); i++) {
			//Car mycar = arrList.get(i);
			
			//mycar.showCarInfo();
			//system.out.println~~ 윗줄 한줄로 합친거
			arrList.get(i).showCarInfo();
		}
		
		
	}

}
