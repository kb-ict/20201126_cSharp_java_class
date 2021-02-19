import java.util.Scanner;

public class If_Dab3_Score {

	public static void main(String[] args) {
		String line = "--------------------";
		System.out.println(line);
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println(line);
		
		System.out.println("100~90 : A학점");
		System.out.println("89~80 : B학점");
		System.out.println("79~70 : C학점");
		System.out.println("69~50 : D학점");
		System.out.println("59~0 : F학점");
		System.out.println(line);
		Scanner sc = new Scanner(System.in);
		System.out.print("1. 국어 점수? ");
		int kr = sc.nextInt();
		//if (kr>100||kr<1) {
		//	System.out.println("0~100사이의 값을 입력하시오");
		//}
		//sc.close();
		//System.exit(0);
		System.out.print("2. 영어 점수? ");
		int eng = sc.nextInt();
		System.out.print("3. 수학 점수? ");
		int math = sc.nextInt();
		
		System.out.println(line);
		int hap = kr + eng + math;
		
		System.out.println("총점 : "+hap);
		int ave = hap/3;
		System.out.println("평균 : "+ave);
		
		if (ave<=100 && ave>=90) {
			System.out.println("학점 : A학점");
		}
		else if (ave<=89 && ave>=80) {
			System.out.println("학점 : B학점");
		}
		else if (ave<=79 && ave>=70) {
			System.out.println("학점 : C학점");
		}
		else if (ave<=69 && ave>=50) {
			System.out.println("학점 : D학점");
		}
		else {
			System.out.println("학점 : F학점");
		}
		sc.close();
	}
	

}
