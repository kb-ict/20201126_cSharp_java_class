import java.util.Scanner;

public class ScannerExam {

	/* 5-2. 과목 총계와 평균 */
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
			System.out.print("1. 국어점수? ");
			int numKr = sc.nextInt();
			System.out.print("2. 영어점수? ");
			int numEng = sc.nextInt();
			System.out.print("3. 수학점수? ");
			int numMath = sc.nextInt();
			System.out.print("4. 과학점수? ");
			int numScience = sc.nextInt();
		
			double average = (numKr+numEng+numMath+numScience)/4;
			int scoreSum = numKr+numEng+numMath+numScience;
		
		System.out.println("---------------------------------");
		System.out.println("평균점수는 "+average+"점입니다.");
		System.out.println("전체 점수합계는 "+scoreSum+"점입니다.");
		
		sc.close();	
	}

}