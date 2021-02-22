package com.j.student;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동",
				"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		Student student[] = new Student[10];
		Random rand = new Random();
		
		for (int i = 0; i < student.length; i++) {
			String _name = name[rand.nextInt(5)];
			int _age = age[rand.nextInt(5)];
			char _gender = gender[rand.nextInt(2)];
			String _address = address[rand.nextInt(5)];
			student[i] = new Student(_name, _age, _gender, _address);
		}
		
		for (var s : student) {
			s.showStudentInfo();
		}
		
		student[9] = new Student("전우치", 24, '남', "조선 항양인근 두메산골");
		student[9].showStudentInfo();
	}

}
