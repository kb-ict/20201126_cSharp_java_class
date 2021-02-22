import java.util.Scanner;

public class Ex030 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int a = s.nextInt();
		int b = s.nextInt();
		int c = s.nextInt();
		int d = s.nextInt();
		int e = s.nextInt();
		if(a<40) {
			a=40;
		}
		if(b<40) {
			b=40;
		}
		if(c<40) {
			c=40;
		}
		if(d<40) {
			d=40;
		}
		if(e<40) {
			e=40;
		}
		System.out.println((a+b+c+d+e)/5);
		s.close();
	}

}
