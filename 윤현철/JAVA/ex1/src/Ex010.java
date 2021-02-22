import java.util.Scanner;

public class Ex010 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("-------------------");
		System.out.println(" 학점 관리 프로그램 1.0 ");
		System.out.println("-------------------");
		System.out.print("국어 점수를 입력하시오 : ");
		int k = sc.nextInt();
		System.out.print("영어 점수를 입력하시오 : ");
		int e = sc.nextInt();
		System.out.print("수학 점수를 입력하시오 : ");
		int m = sc.nextInt();
		
		int a = k+e+m;
		double p = a / 3.0;
				
		System.out.println("총점 : " + a);
		System.out.println("평균 : " + p);
		
		if (p>=90) {
			System.out.println("학점은 A입니다.");
		}
		else if (p>=80) {
			System.out.println("학점은 B입니다.");
		}
		else if (p>=70) {
			System.out.println("학점은 C입니다.");
		}
		else if (p>=60) {
			System.out.println("학점은 D입니다.");
		}
		else if (p>=50) {
			System.out.println("학점은 E입니다.");
		}
		else {
			System.out.println("학점은 F입니다.");
		}
		sc.close();

	}

}
