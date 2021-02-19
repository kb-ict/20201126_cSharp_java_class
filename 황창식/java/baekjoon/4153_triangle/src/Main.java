import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true) {
			int a = s.nextInt(), b = s.nextInt(), c = s.nextInt();
			if(a == 0 && b == 0 && c == 0)
				System.exit(0);
			else {
				if(((a*a) + (b*b) == (c*c)) || ((a*a) + (c*c) == (b*b)) || ((b*b) + (c*c) == (a*a)))
					System.out.println("right");
				else
					System.out.println("wrong");
			}
		}
	}
}
