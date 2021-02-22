import java.util.Scanner;

public class Ex011 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		int C, D, E;
		C = B / 100;
		E = B % 100;
		D = E / 10;
		E = E % 10;
		System.out.println(A*E);
		System.out.println(A*D);
		System.out.println(A*C);
		System.out.println(B*A);
		s.close();
	}

}
