package control;

public class Control5 {

	public static void main(String[] args) {

		// Break Point
		for (int i = 1; i < 10; i++) {
			for (int j = 1; j < 10; j++) {
				if ((i * j) == 72) {
					System.out.println(i + " x " + j + " = " + (i * j));
					break;
				}
			}
		}

	}

}
