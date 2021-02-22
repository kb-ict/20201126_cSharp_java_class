import java.util.Scanner;

public class Ex022 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int T = s.nextInt();
		int x = 1;
		for (int a = 0; a < T; a++) {
			int A = s.nextInt();
			int B = s.nextInt();
			System.out.println("Case #"+ x +": " + A + " + " + B + " = " + (A + B));
			x = x + 1;
		}
		s.close();

	}

}
