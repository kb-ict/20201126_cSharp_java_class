import java.util.Scanner;

public class Problem5 {

	public static void main(String[] args) {
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("     간단 구구단 프로그램 v1.0    ");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		Scanner aa = new Scanner(System.in);
		System.out.print("구구단 입력 => ");
		int num = aa.nextInt();
		int i = 1;
		do {
			System.out.printf("%d x %d = %d\n", num, i, num * i);
			i++;
		} while (i < 10);
		aa.close();
	}

}
