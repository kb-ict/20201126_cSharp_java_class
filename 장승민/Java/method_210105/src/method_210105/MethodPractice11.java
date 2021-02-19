package method_210105;

import java.util.Random;

public class MethodPractice11 {

	public static void main(String[] args) {
		int score[][]=score();									//랜덤수 생성 메쏘드에서 생성된 랜덤수 받는 배열 생성
		
		int sum[]=new int[5];									//총점 배열 생성
		
		for (int i = 0; i < score.length; i++) {				//국, 영, 수 합계를 각인덱스에 삽입
			for (int j = 0; j < score[i].length; j++) {
				sum[i]+=score[i][j];
			}
		}
		double avg[] = new double[5];							//국, 영, 수 평균을 각인덱스에 삽입
		for (int i = 0; i < avg.length; i++) {
			avg[i]=((double)sum[i]/3.0);
		}
		System.out.println("국어\t영어\t수학");
		for (int i = 0; i < score.length; i++) {				//각 인덱스(각 과목 점수)의 학점을 구해 출력
			for (int j = 0; j < score[i].length; j++) {
				if (score[i][j]>=90) System.out.print(score[i][j] + " A\t");
				else if(score[i][j]>=80) System.out.print(score[i][j] + " B\t");
				else if(score[i][j]>=70) System.out.print(score[i][j] + " C\t");
				else if(score[i][j]>=60) System.out.print(score[i][j] + " D\t");
				else if(score[i][j]>=50) System.out.print(score[i][j] + " E\t");
				else System.out.print(score[i][j] + " F\t");
			}
			System.out.print("총점 : "+sum[i]+"\t");
			System.out.print("평균 : "+String.format("%,.1f", avg[i])+"\t");
			System.out.println();
		}

	}
	public static int[][] score() {							//2차원배열의 랜덤수 입력하는 메쏘드
		Random rd = new Random();
		int[][] arr = new int [5][3];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j]=rd.nextInt(60)+41;				//100까지의 랜덤수를 각 인덱스에 삽입
			}
		}
		return arr;
	}

}
