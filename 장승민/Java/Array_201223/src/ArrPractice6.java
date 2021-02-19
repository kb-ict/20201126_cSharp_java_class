
public class ArrPractice6 {

	public static void main(String[] args) {
		int arr1[][] = new int[8][9];

		for (int j = 0; j < 9; j++) {
			int num=2;
			for (int i = 0; i <8 ; i++) {
				arr1[i][j] = num * (j+1);
				System.out.printf("%dX%d=%d\t",i+2,j+1,arr1[i][j]);
				num++;
			}
			System.out.println();
		}
		
	}

}
