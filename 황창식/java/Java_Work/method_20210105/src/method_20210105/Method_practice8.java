package method_20210105;

public class Method_practice8 {

	public static void main(String[] args) {

		holgugu();

	}
	public static void holgugu() {
		for (int i = 1; i < 10; i++) {
			for (int j = 2; j < 10; j++) {
				if(j%2 != 0) {
					System.out.printf("%d x %d = %d\t", j, i, i*j);
				}
			}
			System.out.println();
		}
	}

}
