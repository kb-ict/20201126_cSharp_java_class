
public class Ex8 {

	public static void main(String[] args) {
		fonc();
	}
	public static void fonc() {
		for (int i = 0; i < 9; i++) {
			for (int j = 1; (2*j)+1 < 10; j++) {
				System.out.printf("%d x %d = %d\t",(2*j)+1,i+1,((2*j)+1)*(i+1));
			}
			System.out.println();
		}
	}

}
