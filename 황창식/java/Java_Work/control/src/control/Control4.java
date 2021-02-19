package control;

public class Control4 {

	public static void main(String[] args) {

		// infinite loop
		int num5 = 1;

		while (true) {
			if (((num5 % 6) == 0) && ((num5 % 14) == 0))
				break;
			num5++;
		}
		System.out.println(num5);

		System.out.println("---------------------");

		// for 중첩
		for (int i = 0; i < 3; i++) {
			System.out.println("-----------------");
			for (int j = 0; j < 3; j++) {
				System.out.print("[" + i + "," + j + "] ");
			}
			System.out.println();
		}

		System.out.println("---------------------");

		// while 중첩
		int i = 2;
		int j;

		while (i < 10) {
			j = 1;
			while (j < 10) {
				System.out.println(i + " x " + j + " = " + (i * j));
				j++;
			}
			i++;
			System.out.println();
		}

	}

}
