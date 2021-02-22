import java.util.Scanner;

public class Ex037 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int a = s.nextInt();
		for (int i = a; i >0; i--) {
			for (int j = 0; j < a-i; j++) {
				System.out.print(" ");
			}
			for (int j = 0; j < i; j++) {
				System.out.print("*");
			}
			System.out.println();
		}
		s.close();
	}

}
