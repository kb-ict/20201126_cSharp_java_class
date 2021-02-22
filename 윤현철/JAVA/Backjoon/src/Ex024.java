import java.util.Scanner;

public class Ex024 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		for(int a = 0; a < N; a++) {
			for (int b = 0; b < N-(a+1); b++) {
				System.out.print(" ");
			}
			for (int c = N - a; c < N; c++) {
				System.out.print("*");
			}
			System.out.println("");
		}
		s.close();

	}

}
