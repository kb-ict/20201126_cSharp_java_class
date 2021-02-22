import java.util.Scanner;

public class Ex018 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int T = s.nextInt();
		for (int a = 0; a < T; a++) {
			int A = s.nextInt();
			int B = s.nextInt();
			System.out.println(A + B);
		}
		s.close();
	}

}
