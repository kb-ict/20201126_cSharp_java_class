package condition;

import java.util.Scanner;

public class Yoondal {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String line = "-----------------------------";
		System.out.println(line);
		System.out.println("년도별 윤년 구분 프로그램 v1.0");
		System.out.println(line);
		
		System.out.print("년도 입력 => ");
		
		int year = 0;
		year = sc.nextInt();
		
		if (year%4==0 &&year%100!=0||year%400==0)
		{
			System.out.printf("%d년은 윤년입니다.",year);
		}
		else 
		{
			System.out.printf("%d년은 윤년이 아닙니다.",year);
		}
		
	}

}
