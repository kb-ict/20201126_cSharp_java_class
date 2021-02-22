import java.util.Scanner;

public class Ex017 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		for(int a = 1; a < 10; a++) {
			System.out.println(N + " * " + a + " = " + (N * a));
		}
		s.close();
	}

}
