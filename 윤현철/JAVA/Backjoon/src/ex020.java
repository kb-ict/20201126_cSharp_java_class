import java.util.Scanner;

public class ex020 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		for (int a = 0; a < N; a++) {
			System.out.println(a+1);
		}
		s.close();
	}

}
