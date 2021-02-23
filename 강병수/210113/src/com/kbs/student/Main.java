package com.kbs.student;

import java.util.Random;

public class Main {

	public static void main(String[] args) {
		
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		Student student[] = new Student[10];
		
		Random ran = new Random();
		
		for(int i=0; i<student.length; i++) {
			student[i] = new Student(name[ran.nextInt(5)], address[ran.nextInt(5)], gender[ran.nextInt(2)], age[ran.nextInt(5)]);
		}
		for(int i=0; i<student.length; i++) {
			student[i].showStudentInfo();
			System.out.println("-----------------------");
		}
		//1. 새로운 객체를 생성
		/* student[9] = new Student("전우치", 24, '남', "조선 한양 인근 두메산골");
		 * student[9].showStudentInfo();*/
		
		
		//2.기존의 객체를 재사용 (싱글톤 개념)
		student[9].setName("전우치");
		student[9].setAge(24);
		student[9].setGender('남');
		student[9].setAddress("조선 한양인근 두메산골");
		
		student[9].showStudentInfo();
	}

}
