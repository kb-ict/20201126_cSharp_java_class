import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		Scanner cs=new Scanner(System.in);
		
		double pi = 3.141592;
		System.out.print("반지름을 입력하시오: ");
		double rad = cs.nextDouble();
		System.out.println("원의 면적: " + rad*rad*pi);
		
		System.out.print("국어 점수를 입력하시오: ");
		double kor = cs.nextInt();
		System.out.print("수학 점수를 입력하시오: ");
		double math = cs.nextInt();
		System.out.print("영어 점수를 입력하시오: ");
		double eng = cs.nextInt();
		System.out.print("과학 점수를 입력하시오: ");
		double sci = cs.nextInt();
		
		double total = kor + sci + math + eng;
		double avr = (kor + sci + math + eng)/4;
		
		System.out.println("점수 총합: " + total);
		System.out.println("평균 점수: " + avr);
		cs.close();
		
	}

}
