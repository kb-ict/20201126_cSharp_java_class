
public class Ex6 {

	public static void main(String[] args) {
		int[][] a = new int[9][8];
		for (int i = 0; i < a.length; i++) {
			for (int j = 0; j < a[i].length; j++) {
				a[i][j]=(i+1)*(j+2);
			}
		}
		for (int i = 0; i < a.length; i++) {
			for (int j = 0; j < a[i].length; j++) {
				System.out.printf("%d x %d = %d\t",j+2,i+1,a[i][j]);
			}
			System.out.println();
		}
	}

}
