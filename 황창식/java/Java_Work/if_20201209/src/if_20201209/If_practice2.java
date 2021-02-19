package if_20201209;

import java.util.Scanner;

public class If_practice2 {

	public static void main(String[] args) {
		System.out.println("-------------------");
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println("-------------------");
		System.out.println("100 ~ 90 : A학점");
		System.out.println("89 ~ 80  : B학점");
		System.out.println("79 ~ 70  : C학점");
		System.out.println("69 ~ 60  : D학점");
		System.out.println("59 ~ 0   : F학점");
		System.out.println("-------------------");
		
		Scanner s = new Scanner(System.in);
		System.out.print("국어 점수 입력 : ");
		int kor = s.nextInt();
		System.out.print("영어 점수 입력 : ");
		int eng = s.nextInt();
		System.out.print("수학 점수 입력 : ");
		int math = s.nextInt();
		System.out.println("-------------------");
		
		int sum = kor + eng + math;
		System.out.println("총점 : " + sum);
		int ave = sum / 3;
		System.out.println("평균 : " + ave);
		if(100 >= ave && ave >= 90) {
			System.out.println("A학점입니다.");
		}
		else if(89 >= ave && ave >= 80) {
			System.out.println("B학점입니다.");
		}
		else if(79 >= ave && ave >= 70) {
			System.out.println("C학점입니다.");
		}
		else if(69 >= ave && ave >= 60) {
			System.out.println("D학점입니다.");
		}
		else {
			System.out.println("F학점입니다.");
		}
		
		s.close();

	}

}
