package method_201230;

import java.util.Scanner;

public class MethodPractice4 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int kor = sc.nextInt();		//국어 점수 입력
		
		while (true) {
			if (kor>100||kor<0) {
				System.out.println("점수 범위가 틀렸습니다. 다시 입력하십시오.");
				kor=sc.nextInt();	//점수 범위가 틀렸을 시 다시 입력
			}
			else break;				//점수 범위가 제대로 입력되었을시 다음 단계로 진행
		}
		int eng = sc.nextInt();
		while (true) {
			if (eng>100||eng<0) {
				System.out.println("점수 범위가 틀렸습니다. 다시 입력하십시오.");
				eng=sc.nextInt();	//점수 범위가 틀렸을 시 다시 입력
			}
			else break;				//점수 범위가 제대로 입력되었을시 다음 단계로 진행
		}
		int math = sc.nextInt();
		while (true) {
			if (math>100||math<0) {
				System.out.println("점수 범위가 틀렸습니다. 다시 입력하십시오.");
				math=sc.nextInt();	//점수 범위가 틀렸을 시 다시 입력
			}
			else break;				//점수 범위가 제대로 입력되었을시 다음 단계로 진행
		}	
		sc.close();
		func(kor,eng,math);			//총점 및 평균구하는 메쏘드 호출
	}
	public static void func(int a, int b, int c) {	//국, 영, 수 점수를 각 매개변수로 받는 메쏘드 생성

		int sum = a+b+c;							//국, 영, 수 총점 구하는 sum 변수 생성과 동시에 값 초기화
		double avg = sum/3.0;						//국, 영, 수 평균 구하는 avg 변수 생성과 동시에 값 초기화
		System.out.println("총 점 : " + sum);
		System.out.println("평 균 : " + avg);
	}

}
