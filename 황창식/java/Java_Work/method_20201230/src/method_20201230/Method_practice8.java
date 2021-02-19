package method_20201230;

public class Method_practice8 {

	public static void main(String[] args) {
		
		holgugu();
	}
	public static void holgugu() {
		for (int i = 1; i <= 9; i++) {
			for (int j = 2; j <= 9; j++) {
				if(j%2 == 1) {
					System.out.printf("%d x %d = %d\t", j, i, j*i);
				}
			}
			System.out.println();
		}
	}

}
