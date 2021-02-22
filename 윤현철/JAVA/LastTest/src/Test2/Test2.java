package Test2;
import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("년도를 입력하세요 : ");
		int year = s.nextInt();
		int a = year%12;
		if (a==1) {
			System.out.println("닭띠입니다.");
		}
		else if (a==2) {
			System.out.println("개띠입니다.");
		}
		else if (a==3) {
			System.out.println("돼지띠입니다.");
		}
		else if (a==4) {
			System.out.println("쥐띠입니다.");
		}
		else if (a==5) {
			System.out.println("소띠입니다.");
		}
		else if (a==6) {
			System.out.println("호랑이띠입니다.");
		}
		else if (a==7) {
			System.out.println("토끼띠입니다.");
		}
		else if (a==8) {
			System.out.println("용띠입니다.");
		}
		else if (a==9) {
			System.out.println("뱀띠입니다.");
		}
		else if (a==10) {
			System.out.println("말띠입니다.");
		}
		else if (a==11) {
			System.out.println("양띠입니다.");
		}
		else {
			System.out.println("원숭이띠입니다.");
		}
		s.close();
	}
	
}
