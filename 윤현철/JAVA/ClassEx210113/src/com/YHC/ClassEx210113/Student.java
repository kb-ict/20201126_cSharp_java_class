package com.YHC.ClassEx210113;

public class Student {
	private String name;
	private int age;
	private char gender;
	private String address;
	
	public Student(String name, int age, char gender, String address) {
		super();
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	}

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
	public void showStudentInfo(){
		System.out.println(name);
		System.out.println(age);
		System.out.println(gender);
		System.out.println(address);
		System.out.println("-------------------------");
	}
}
