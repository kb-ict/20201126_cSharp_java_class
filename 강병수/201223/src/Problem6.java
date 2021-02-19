
public class Problem6 {

	public static void main(String[] args) {
		int arr1[][] = new int[9][8];

		for (int i = 0; i < arr1.length/* 9행 */; i++) {
			for (int j = 0; j < arr1[i].length/* 8열 */; j++) {
//				arr1[0][j] = j + 2;
//				arr1[i][0] = i + 1;
				arr1[i][j] = (j+2)*(i+1);
				System.out.printf("%dx%d=%d\t", j+2, i+1, arr1[i][j]);
			}
			System.out.println();
		}

	}

}
