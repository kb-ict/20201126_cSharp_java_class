package method_20210105;

import java.util.Scanner;

public class Method_practice11 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int stuscore[][] = score();
		scoretable(stuscore);
		while(true) {
			System.out.println("---------------------------");
			System.out.print("몇 번 학생이 궁금하십니까? : ");
			int stunum = s.nextInt() - 1;
			if(4 >=stunum && stunum >= 0) {
				System.out.println("---------------------------");
				System.out.println(stunum + 1 + "번 학생 결과");
				System.out.println("총점 : " + sum(stuscore, stunum));
				System.out.println("평균 : " + ave(sum(stuscore, stunum)));
				System.out.println("학점은 " + hakjeom(ave(sum(stuscore, stunum))) + "입니다.");
			}
			else if((stunum+1) == 0) {
				System.out.println("---------------------------");
				System.out.println("프로그램을 종료합니다.");
				System.exit(0);
			}
			else {
				System.out.println("---------------------------");
				System.out.println("잘못 입력하셨습니다.");
				continue;
			}
			
		}
		
		

	}
	
	public static int[][] score(){
		int score[][] = new int[5][3];
		for (int i = 0; i < score.length; i++) {
			for (int j = 0; j < score[i].length; j++) {
				score[i][j] = (int)(Math.random()*50)+51;
			}
		}
		return score;
	}
	
	public static void scoretable(int[][] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(i+1 + "번 학생 : ");
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + "\t");
			}
			System.out.println();
		}
	}
	
	public static int sum (int[][] arr, int num) {
		int sum = 0;
		for (int i = 0; i < arr[num].length; i++) {
			sum += arr[num][i];
		}
		return sum;
	}
	
	public static double ave (int num) {
		double result = num / 3.0;
		return result;
	}
	
	public static String hakjeom(double num) {
		String result;
		if(100>=num&&num>=90) {
			result = "A";
		}
		else if(89>=num&&num>=80) {
			result = "B";
		}
		else if(79>=num&&num>=70) {
			result = "C";
		}
		else if(69>=num&&num>=60) {
			result = "D";
		}
		else {
			result = "F";
		}
		return result;
	}
	
	
	
	

}
