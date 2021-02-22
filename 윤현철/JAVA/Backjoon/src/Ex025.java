import java.util.Scanner;

public class Ex025 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		int X = s.nextInt();
		for (int a = 0; a < N; a++) {
			int b = s.nextInt();
			if (b < X) {
				System.out.print(b + " ");
			}
			
		}
		s.close();
	}

}
