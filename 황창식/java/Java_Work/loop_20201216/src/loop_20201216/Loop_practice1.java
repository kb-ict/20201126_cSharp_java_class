package loop_20201216;

public class Loop_practice1 {

	public static void main(String[] args) {
		System.out.println("-------------------------");
		System.out.println("5의 배수 출력 프로그램 v1.0");
		System.out.println("-------------------------");

		System.out.println("For 문");
		for (int i = 0; i < 100; i++) {
			if ((i + 1) % 5 == 0) {
				System.out.print((i + 1) + " ");
			}
		}
		System.out.println("\n-------------------------");

		System.out.println("While 문");
		int i = 0;
		while (i < 100) {
			if ((i + 1) % 5 == 0) {
				System.out.print((i + 1) + " ");
			}
			i++;
		}

		System.out.println("\n-------------------------");

		System.out.println("Do While 문");
		i = 0;
		do {
			if ((i + 1) % 5 == 0) {
				System.out.print((i + 1) + " ");
			}
			i++;
		} while (i < 100);

	}

}
