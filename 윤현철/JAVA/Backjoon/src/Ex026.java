import java.util.Scanner;

public class Ex026 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = 1;
		int B = 1;
		while(A != 0 && B != 0){
			A = s.nextInt();
			B = s.nextInt();
			if(A != 0 && B != 0) {
				System.out.println(A + B);
			}
		}
		s.close();
	}
}
