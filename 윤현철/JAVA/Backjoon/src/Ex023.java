import java.util.Scanner;

public class Ex023 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		for(int a = 1; a <= N; a++) {
			for (int b = 1; b <= a; b++) {
				System.out.print("*");
			}
			System.out.println("");
		}
		s.close();
	}
}
