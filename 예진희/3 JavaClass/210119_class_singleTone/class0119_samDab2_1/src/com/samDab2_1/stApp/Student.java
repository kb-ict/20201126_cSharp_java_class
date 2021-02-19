package com.samDab2_1.stApp;
public class Student {
//학생 관리프로그램, 정보관리
//객체지향에서 변수를 속성이라 함
//문제풀이 확장 더하고 변혀어어엉
	private String name;
	private int age;
	private char gender;
	private String address;
//constructor = 생성자 , field 속성, 변수
	
	public Student(String name, int age, char gender, String address) {
		super(); //부모 클래스 Object
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	} //객체생성시 정보 받아와서 값 설정...

	
	// 클래스 계층도, 라이브러리 오브젝트 최상이클래스 상속받아 만들어진다.
	// super(); 부모클래스
	
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}
	//static없으므로 인스턴스 변수name, this.address
	//클래스 : 클래스메소드, 인스턴스 메소드ㅇ
	public void showStudentInfo() {
		System.out.println("이름: "+name);
		System.out.println("나이: "+age);
		System.out.println("성별: "+gender);
		System.out.println("주소: "+address);
		System.out.println("---------------------------\n");
		
	}
}
