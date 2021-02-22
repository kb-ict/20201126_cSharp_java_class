import java.util.Scanner;

public class Ex035 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		int C = s.nextInt();
		int max = A;
		int min = A;
		if(max<B) {
			max=B;
			}
		if(max<C) {
			max=C;
			}
		if (min>B) {
			min=B;
		}
		if(min>C) {
			min=C;
		}
		if(max==A && min==B) {
			System.out.println(C);
			System.exit(0);
		}
		if(max==B && min==C) {
			System.out.println(A);
			System.exit(0);
		}
		if(max==C && min==A) {
			System.out.println(B);
			System.exit(0);
		}
		if(max==C && min==B) {
			System.out.println(A);
			System.exit(0);
		}
		if(max==A && min==C) {
			System.out.println(B);
			System.exit(0);
		}if(max==B && min==A) {
			System.out.println(C);
			System.exit(0);
		}
		s.close();
	}

}
