package beak;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Scanner;


public class Beak1546 {

	public static void main(String[] args) throws IOException {
		
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();	// 과목 수 입력
		int [] sub = new int[N];					// 과목 수(인덱스)에 해당하는 배열 생성
											
		
		for (int i = 0; i < sub.length; i++) {
			sub[i] = sc.nextInt();//각 과목의 점수 입력 -> 배열의 인덱스에 삽입
		}
		sc.close();
		
									// 최고점수 변수 배열의 첫번째 인덱스 값으로 초기화				
		Arrays.sort(sub);
		double M = sub[sub.length-1];
		
		double []newscore=new double[sub.length];
		for (int i = 0; i < newscore.length; i++) {
			newscore[i] = (sub[i]/M)*100.0;
		}
		double sum=0;
				
		for (int i = 0; i < newscore.length; i++) {
			sum+=newscore[i];
		}
		double avg = sum/newscore.length;
		System.out.println(String.format("%.2f",avg ));
	}

}
