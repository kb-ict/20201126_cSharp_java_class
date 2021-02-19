package method_20201230;

public class Method_practice1 {

	public static void main(String[] args) {

		numcomp(5, 15, 10);
		numcomp(5, 10, 15);
		numcomp(10, 5, 15);
		numcomp(10, 15, 5);
		numcomp(15, 10, 5);
		numcomp(15, 5, 10);
		
		

	}
	
	public static void numcomp(int a, int b, int c) {
		if(a > b && b > c) {
			System.out.printf("%d-%d-%d\n", a, b, c);
		}
		else if(a > b && b < c && a > c) {
			System.out.printf("%d-%d-%d\n", a, c, b);
		}
		else if(a < b && a > c) {
			System.out.printf("%d-%d-%d\n", b, a, c);
		}
		else if(a < b && a < c && b > c) {
			System.out.printf("%d-%d-%d\n", b, c, a);
		}
		else if(a > b && b < c && a < c) {
			System.out.printf("%d-%d-%d\n", c, a, b);
		}
		else if(a < b && b < c) {
			System.out.printf("%d-%d-%d\n", c, b, a);
		}
		
	}

}
