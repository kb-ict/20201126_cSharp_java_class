package control;

public class Control2 {

	public static void main(String[] args) {

		// while
		int num1 = 0;
		while (num1 < 5) {
			System.out.println("I like Java " + num1);
			num1++;
		}

		System.out.println("---------------------");

		// do while
		int num2 = 0;
		do {
			System.out.println("I like Java " + num2);
			num2++;
		} while (num2 < 5);

		System.out.println("---------------------");

		// for
		for (int i = 0; i < 5; i++) {
			System.out.println("I like Java " + i);
		}

	}

}
