import java.util.Scanner;

public class Ex028 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		int a = 0;
		int e = N;
		while(true) {
			int b = e / 10;
			int c = e % 10;
			int d = b + c;
			e = (c*10) + (d % 10);
			++a;
			if(e == N) {
				System.out.println(a);
				s.close();
				break;
			}
		}
	}
}
