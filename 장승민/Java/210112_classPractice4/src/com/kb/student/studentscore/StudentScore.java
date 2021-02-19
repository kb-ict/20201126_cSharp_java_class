package com.kb.student.studentscore;

import java.util.Random;

public class StudentScore {
	Random rd = new Random();

	private String eng;
	private String kor;
	private String math;
	private int score;
	private String hakjum;
	private int sum;
	private double avg;

	public int score() {
		score = rd.nextInt(70) + 31;
		return score;
	}
	
	public String hakjum(int score) {
		if(score>=90) hakjum="A";
		else if(score<90&&score>=80) hakjum="B";
		else if(score<80&&score>=70) hakjum="C";
		else if(score<70&&score>=60) hakjum="D";
		else if(score<60&&score>=50) hakjum="E";
		else hakjum="F";
		return hakjum;
	}

	public String eng() {
		eng = "영어" +" "+ score() +" "+ hakjum(score);
		sum+=score;
		return eng;
	}

	public String kor() {
		kor = "국어" +" "+ score() +" "+ hakjum(score);
		sum+=score;
		return kor;
	}

	public String math() {
		math = "수학" +" "+ score() +" "+ hakjum(score);
		sum+=score;
		return math;
	}

	public double avg(int sum) {
		avg = (double)sum/3;
		return avg;
	}
	
		
	
	public void showStudentInfo() {
		System.out.println(eng());
		System.out.println(kor());
		System.out.println(math());
		System.out.println("총점 "+sum);
		System.out.println("평균 "+String.format("%.2f",avg(sum)));
		System.out.println("평균학점 " + hakjum((int)avg));
		System.out.println("-----------");
	}

}
