
public class Ex6_3 {

	public static void main(String[] args) {
		System.out.println("-------------------");
		System.out.println(" 구구단 프로그램 v1.0");
		System.out.println("-------------------");
		int a = 0;
		int b = 1;
		do {
			do {
				System.out.printf("%dx%d=%d\t", (b+1), (a+1), (a+1)*(b+1));
				b++;
			}while(b<9);
			System.out.println("");
			a++;
			b=1;
		}while(a<9);

	}

}
