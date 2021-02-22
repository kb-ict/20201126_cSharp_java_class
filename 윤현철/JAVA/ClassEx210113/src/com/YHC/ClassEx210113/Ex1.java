package com.YHC.ClassEx210113;

import java.util.Random;

public class Ex1 {

	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		Random r = new Random();		
		Student st[] = new Student[10];
		for (int i=0; i<st.length; i++) {
			st[i] =new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
		}
		
//		Student Student = new Student(name, age, gender, address);
//		Student.showStudentInfo();
		st[9].setName("전우치");
		st[9].setAge(24);
		st[9].setGender('남');
		st[9].setAddress("조선 한양인근 두메산골");
		for (int i = 0; i < st.length; i++) {
			st[i].showStudentInfo();
		}
	}

}
