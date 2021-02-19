package com.hcs.stApp;
public class StAppMain {
	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		System.out.println("----------학생정보----------");
		
		Student std[] = new Student[10];
		for (int i = 0; i < std.length; i++) {
			std[i] = new Student(name[(int)(Math.random()*5)], age[(int)(Math.random()*5)], gender[(int)(Math.random()*2)], address[(int)(Math.random()*5)]);
			System.out.println(i+1 + "번 학생 정보");
			std[i].showStudentInfo();
		}
		
		// 1. 새로운 객체를 생성
		std[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
		System.out.println("10번 학생 수정 정보 - 1");		
		std[9].showStudentInfo();
		
		//--------------------------------------
		
		// 2. 기존의 객체를 재사용 (싱글톤)
		std[9].setName("전우치");
		std[9].setAge(24);
		std[9].setGender('남');
		std[9].setAddress("조선 한양 인근 두메산골");
		System.out.println("10번 학생 수정 정보 - 2");
		std[9].showStudentInfo();
		
		
		
		
		
		
		
	}

}
