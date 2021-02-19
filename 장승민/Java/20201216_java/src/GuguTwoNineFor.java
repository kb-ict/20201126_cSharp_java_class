
public class GuguTwoNineFor {

	public static void main(String[] args) {

		String line = "----------------------";
		System.out.println(line);
		System.out.println("구구단 프로그램 v1.0");
		System.out.println(line);
		for (int i = 0; i < 9; i++) {
			for (int j = 1; j < 9; j++) {
				int res = (j + 1) * (i + 1);
				System.out.printf("%dX%d=%d\t", (j + 1), (i + 1), res);
			}
			System.out.println(" ");
		}

	}

}
