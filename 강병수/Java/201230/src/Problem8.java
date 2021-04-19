//아직 못품

public class Problem8 {

	public static void even(int arr1[][]) {

	}

	public static void main(String[] args) {
		int arr1[][] = new int[9][8];
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1[i].length; j++) {
				arr1[i][j] = (j + 2) * (i + 1);
				if((j+2)%2 == 1) {
				System.out.printf("%dx%d=%d\t", j + 2, i + 1, arr1[i][j]);
				}
			}
			System.out.println();
		}

	}

}