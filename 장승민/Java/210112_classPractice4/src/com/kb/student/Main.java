package com.kb.student;

import java.util.ArrayList;

import com.kb.student.studentscore.StudentScore;

public class Main {

	public static void main(String[] args) {
		StudentScore ss[] = new StudentScore[10];
		
		for (int i = 0; i < 5; i++) {
			ss[i] = new StudentScore();
			ss[i].showStudentInfo();
		}

	}

}
