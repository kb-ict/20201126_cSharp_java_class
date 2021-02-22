import java.util.Scanner;

public class Ex5_1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("---------------------");
		System.out.println("간단 구구단 프로그램 v1.0");
		System.out.println("---------------------");
		System.out.print("1. 구구단 입력 => ");
		int a = s.nextInt();
		for (int i=0; i<9; i++) {
			System.out.printf("%d x %d = %d\n", a, (i+1), a*(i+1));
		}
		s.close();
	}

}
