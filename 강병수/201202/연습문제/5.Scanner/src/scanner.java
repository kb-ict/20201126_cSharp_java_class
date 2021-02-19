import java.util.Scanner;

public class scanner {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("반지름을 입력하시오: ");
		float rad = sc.nextFloat();
		float pi = 3.14f;

		System.out.println("원의 면적: " + pi*rad*rad);
		System.out.println("─────────────────────");
		
		System.out.print("국어 점수를 입력하시오: ");
		int kor =sc.nextInt();
		System.out.print("영어 점수를 입력하시오: ");
		int eng =sc.nextInt();
		System.out.print("수학 점수를 입력하시오: ");
		int math =sc.nextInt();
		System.out.print("과학 점수를 입력하시오: ");
		int sci =sc.nextInt();
		
		double avr = (kor+eng+math+sci)/4;
		int total = kor+eng+math+sci;
		
		System.out.println("평균 점수: " + avr);
		System.out.println("총점수: " + total);
		System.out.println("─────────────────────");
	}

}
