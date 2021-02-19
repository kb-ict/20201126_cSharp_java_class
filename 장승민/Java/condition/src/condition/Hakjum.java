package condition;

import java.util.Scanner;

public class Hakjum {

	public static void main(String[] args) {

		String line = "-------------------------";
		System.out.println(line);
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println(line);
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("국어 점수 입력 =>");
		int kor = sc.nextInt();
		System.out.print("영어 점수 입력 =>");
		int eng = sc.nextInt();
		System.out.print("수학 점수 입력 =>");
		int math = sc.nextInt();
	
		int sum = kor + eng + math ;
		double avg = sum/3.0;
		
		if (avg>=90)
		{
			System.out.println("총점 "+sum);
			System.out.println("평균 "+avg);
			System.out.println("학점은 A입니다.");
		}
		else if(90>avg&&avg>=80)
			{
				System.out.println("총점 "+sum);
				System.out.println("평균 "+avg);
				System.out.println("학점은 B입니다.");
			}
		else if(80>avg&&avg>=70)
			{
				System.out.println("총점 "+sum);
				System.out.println("평균 "+avg);
				System.out.println("학점은 C입니다.");
			}
		else if(70>avg&&avg>=60)
			{
				System.out.println("총점 "+sum);
				System.out.println("평균 "+avg);
				System.out.println("학점은 D입니다.");
			}
		else if(60>avg&&avg>=50)
		{
			System.out.println("총점 "+sum);
			System.out.println("평균 "+avg);
			System.out.println("학점은 E입니다.");
		}
		else
		{
			System.out.println("총점 "+sum);
			System.out.println("평균 "+avg);
			System.out.println("학점은 F입니다.");
		}
		
	
	
	
	}

}
