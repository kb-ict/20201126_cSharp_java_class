
public class Ex6_2 {

	public static void main(String[] args) {
		System.out.println("-------------------");
		System.out.println(" 구구단 프로그램 v1.0");
		System.out.println("-------------------");
		int a = 0;
		int b = 1;
		while(a<9) {
			while(b<9) {
				System.out.printf("%dx%d=%d\t", (b+1), (a+1), (a+1)*(b+1));
				b++;
			}
			System.out.println("");
			a++;
			b=1;
		}
	}

}
