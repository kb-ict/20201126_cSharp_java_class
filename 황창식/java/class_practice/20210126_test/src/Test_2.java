import java.util.Scanner;
public class Test_2 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int year = s.nextInt();
		System.out.println(getDDi(year));
		s.close();
	}
	public static String getDDi(int num) {
		if(num%12 == 1) {
			return "닭";
		}
		else if(num%12 == 2) {
			return "개";
		}
		else if(num%12 == 3) {
			return "돼지";
		}
		else if(num%12 == 4) {
			return "쥐";
		}
		else if(num%12 == 5) {
			return "소";
		}
		else if(num%12 == 6) {
			return "호랑이";
		}
		else if(num%12 == 7) {
			return "토끼";
		}
		else if(num%12 == 8) {
			return "용";
		}
		else if(num%12 == 9) {
			return "뱀";
		}
		else if(num%12 == 10) {
			return "말";
		}
		else if(num%12 == 11) {
			return "양";
		}
		else if(num%12 == 0) {
			return "원숭이";
		}
		else {
			return "잘못 입력하셨습니다";
		}
	}
}
