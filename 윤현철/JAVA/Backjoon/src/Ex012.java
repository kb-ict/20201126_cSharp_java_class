import java.util.Scanner;

public class Ex012 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		if (A > B) {
			System.out.println(">");
		}
		else if (A < B) {
			System.out.println("<");
		}
		else if (A == B) {
			System.out.println("==");
		}
		
		s.close();
	}

}
