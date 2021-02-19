import java.util.Scanner;
public class ScannerExam_Circle {
	
	/* 5-1. 반지름값 입력받아 원의 넓이 구하기 */
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("반지름을 입력하세요: ");
		int r = sc.nextInt();
		
		final double PI = 3.14;
		System.out.println("----------------------------");
		System.out.println("원의 넓이는: "+r*r*PI+"입니다.");
		sc.close();	
	}

}
