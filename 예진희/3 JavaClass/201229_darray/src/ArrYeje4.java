import java.util.Scanner;

public class ArrYeje4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("���� ���� �Է�: ");
		int row = s.nextInt();
		System.out.print("���� ���� �Է�: ");
		int col = s.nextInt();

		int arr[][] = new int[row][col];
		int value = 1;

		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				arr[i][j] = value++;
			}
		}
		System.out.printf("arr[0][0] ~ arr[%d][%d]\n", (row-1), (col-1));

		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				System.out.printf("arr[%d][%d] : %d \t", i, j, (arr[i][j]));
			}System.out.println();
		}
		s.close();
	}
}	//���ϸ� �޼ҵ� ����, ����(sort) 221671074310
