
public class Problem1 {

	public static void main(String[] args) {
		int arr1[][] = new int[3][3];
		int value = 1;
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				arr1[i][j] = value;
				value++;
			}
		}
		int arr2[][] = new int[3][3];
		int value2 = 10;
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				arr2[i][j] = value2;
				value2 += 10;
			}
		}
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.print(arr1[i][j] + arr2[i][j] + "\t");
			}

			System.out.println("");
		}

	}

}
