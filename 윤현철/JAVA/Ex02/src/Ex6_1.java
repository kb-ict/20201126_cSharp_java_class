
public class Ex6_1 {

	public static void main(String[] args) {
		System.out.println("-------------------");
		System.out.println(" 구구단 프로그램 v1.0");
		System.out.println("-------------------");
		for (int a=0; a<9; a++) {
			for (int b=1; b<9; b++) {
				System.out.printf("%d x %d = %d	", (b+1), (a+1), (a+1)*(b+1));
			}
			System.out.println("");
		}
	}
}
