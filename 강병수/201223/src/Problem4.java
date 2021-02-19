//풀긴 품
public class Problem4 {

	public static void main(String[] args) {
		int arr[][] = {{1,2},{2,4},{3,6},{4,8},{5,10}};
		for (int i= 0; i<5; i++) {
			for (int j=0; j<2; j++) {
				System.out.printf("arr[%d][%d]=%d  ", i, j, arr[i][j]);
			}
			System.out.println();
		}

	}

}
