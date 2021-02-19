package com.samDab2_1.stApp;

import java.util.Random;

public class StAppMain {

	public static void main(String[] args) {
		
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		int age[] = { 20, 25, 30, 35, 40 };
		char gender[] = { '남', '여' };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		
		
		Student st[] = new Student[10]; //빈배열 클래스, 객체생성x
		Random r = new Random();

//		1명에 대한 정보디버깅
//		st[0] = new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
//		st[0].showStudentInfo();
		
		for (int i = 0; i < st.length; i++) {
			System.out.println("-- "+(i+1)+"번째 학생\t-----------");
			//빈배열 객체생성해서 연결
			//st[i] 새로만들고 연결, 생성객체를 마킹
			st[i] = new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
			st[i].showStudentInfo();
		}
		// 방법 1번 : 새로운 객체 생성 / 기존 만들어진 10번째 객체 기존거 연결끊고 새로만든걸로 연결 ----------------
		// 매번새로 생성시 시스템 과부하..
		st[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
		st[9].showStudentInfo();
		// 방법 2번 : 기존 객체 재사용(싱글톤) / 기존객체 재사용 ex)DB, 로그인 정보 획득정보 유지필요성 ㅇ ----------
		st[9].setName("하우치");
		st[9].setAge(99);
		st[9].setGender('남');
		st[9].setAddress("조선 한양인근 두메산골");
		st[9].showStudentInfo();
		
//		향상된 for문, 객체만들고 바로출력 재사용 불가능
//		for(int i=0; i<st.length; i++) {
//			new Student(name[r.nextInt(5)], age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]).showStudentInfo();
//		}
	}
}
