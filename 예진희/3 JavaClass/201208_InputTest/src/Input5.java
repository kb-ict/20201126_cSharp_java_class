import java.util.Scanner;

public class Input5 {

	public static void main(String[] args) {
		// 실습 5-3번 문제
		// 국, 영, 수, 과 점수를 입력하고 평균값과 총점을 출력
		
		Scanner sc = new Scanner(System.in);
		System.out.print("1. 국어점수: ");
		int kr = sc.nextInt();
		System.out.print("2. 영어점수: ");
		int eng = sc.nextInt();
		System.out.print("3. 수학점수: ");
		int math = sc.nextInt();
		System.out.print("4. 과학점수: ");
		int science = sc.nextInt();	
				
		int total = kr+eng+math+science;
		int ave = (kr+eng+math+science)/4;
		
		System.out.println("전체과목 총점수: "+total);
		System.out.println("평균: "+ave);
		sc.close();

	}

}
