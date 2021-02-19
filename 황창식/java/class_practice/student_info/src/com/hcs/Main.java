package com.hcs;

public class Main {

	public static void main(String[] args) {
		System.out.println("학생 정보");
		System.out.println("-------------------------");
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		StudentInfo[] si = new StudentInfo[10];
		for (int i = 0; i < si.length; i++) {
			si[i] = new StudentInfo(name[(int)(Math.random()*5)], age[(int)(Math.random()*5)], gender[(int)(Math.random()*2)], address[(int)(Math.random()*5)]);
			System.out.println((i+1) + "번 학생 정보");
			si[i].showStudentInfo();
		}
		si[9].setName("전우치");
		si[9].setAge(24);
		si[9].setGender('남');
		si[9].setAddress("조선 한양인근 두메산골");
		System.out.println("10번 학생 수정");
		si[9].showStudentInfo();
		
	}
	
	

}
