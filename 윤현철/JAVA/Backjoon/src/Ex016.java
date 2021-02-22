import java.util.Scanner;

public class Ex016 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		B = B - 45;
		if (A > 0 && B < 0) {
			A = A - 1;
			B = B + 60;
		}
		else if (A == 0 && B < 0) {
			A = A + 23;
			B = B + 60;
		}
		System.out.println(A + " " + B);
		s.close();
	}
}
