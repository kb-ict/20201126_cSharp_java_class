package loop_20201216;

public class Loop_practice5 {

	public static void main(String[] args) {
		System.out.println("------------------");
		System.out.println("구구단 프로그램 v1.0");
		System.out.println("------------------");

		System.out.println("For 문");
		int result = 0;
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 8; j++) {
				result = (j + 2) * (i + 1);
				System.out.printf("%d x %d = %d\t", j + 2, i + 1, result);
			}
			System.out.println();
		}

		System.out.println("------------------");

		System.out.println("While 문");
		result = 0;
		int i = 0;
		int j;
		while (i < 9) {
			j = 0;
			while (j < 8) {
				result = (j + 2) * (i + 1);
				System.out.printf("%d x %d = %d\t", j + 2, i + 1, result);
				j++;
			}
			i++;
			System.out.println();
		}

		System.out.println("------------------");

		System.out.println("Do While 문");
		result = 0;
		i = 0;
		do {
			j = 0;
			do {
				result = (j + 2) * (i + 1);
				System.out.printf("%d x %d = %d\t", j + 2, i + 1, result);
				j++;
			}while(j < 8);
			i++;
			System.out.println();
		}while(i < 9);
	}

}
