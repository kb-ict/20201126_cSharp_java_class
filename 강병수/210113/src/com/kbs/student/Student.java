package com.kbs.student;

public class Student {

	private String name;
	private String address;
	private char gender;
	private int age;
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public Student(String name, String address, char gender, int age) {
		this.name = name;
		this.address = address;
		this.gender = gender;
		this.age = age;
	}
	
	public void showStudentInfo() {
		System.out.println("이름: " + name);
		System.out.println("나이: " + age);
		System.out.println("성별: " + gender);
		System.out.println("주소: " + address);
		
	}
	
}
