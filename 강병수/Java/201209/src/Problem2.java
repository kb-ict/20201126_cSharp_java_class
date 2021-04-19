import java.util.Scanner;

public class Problem2 {

	public static void main(String[] args) {
	Scanner far = new Scanner(System.in);
	System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
	System.out.println("대소 비교 프로그램 v1.0");
	System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		
		System.out.print("num1 입력: ");
		int num1 = far.nextInt();
		System.out.print("num2 입력: ");
		int num2 = far.nextInt();
		
		if(num1 > num2) {
			System.out.println("num1이 num2보다 크다.");
		}
		else if(num1 < num2) {
			System.out.println("num2가 num1보다 크다.");
		}
		else if(num1 == num2) {
			System.out.println("num1과 num2는 같다.");
		}
		far.close();
	}

}
