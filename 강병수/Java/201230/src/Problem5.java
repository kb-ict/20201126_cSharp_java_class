import java.util.Scanner;

public class Problem5 {


	public static void multi(int num) { //구구단 출력 메소드
		for (int i = 1; i<10; i++) {
			System.out.printf("%d * %d = %d\t", num, i, num*i );
		}
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		multi(num);
		sc.close();

	}
	
}
