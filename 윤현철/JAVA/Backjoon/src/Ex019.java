import java.util.Scanner;

public class Ex019 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int sum = 0;
		for (int a = 0; a < n; a++) {
			sum = sum + (a + 1);
		}
		System.out.println(sum);
		s.close();
	}

}
