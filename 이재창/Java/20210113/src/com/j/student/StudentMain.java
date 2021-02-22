package com.j.student;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		String name[] = {"ȫ�浿", "��浿", "�ڱ浿", "�̱浿", "�ֱ浿"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'��', '��'};
		String address[] = {"�뱸�� ���� �ž�4��", "����� ���� �ž�4��",
				"�λ�� ���� �ž�4��", "��õ�� ���� �ž�4��", "���ֽ� ���� �ž�4��"};
		
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
		
		student[9] = new Student("����ġ", 24, '��', "���� �׾��α� �θ޻��");
		student[9].showStudentInfo();
	}

}
