import java.util.Scanner;

public class Ex015 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		if(A > 0 && B > 0) {
			System.out.println("1");
		}
		else if (A < 0 && B > 0) {
			System.out.println("2");
		}
		else if (A < 0 && B < 0) {
			System.out.println("3");
		}
		else if (A > 0 && B < 0) {
			System.out.println("4");
		}
		s.close();
	}

}
