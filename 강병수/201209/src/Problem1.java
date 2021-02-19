import java.util.Scanner;

public class Problem1 {

	public static void main(String[] args) {
	Scanner odd = new Scanner(System.in);
	
	System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
	System.out.println("홀짝 판단 프로그램 v1.0");
	System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
	System.out.print("숫자 입력: ");
	int number = odd.nextInt();
		if(number%2 == 0) {
			System.out.println("입력한 숫자는 짝수입니다.");
		}
		else {
			System.out.println("입력한 숫자는 홀수입니다.");
		}
		odd.close();
	}

}
