public class myPulee4 {// 4�� ����

	public static void main(String[] args) {
		int arr[][] = { //5�� =i 2�� = j
				{ 1, 2 },
				{ 2, 4 },
				{ 3, 6 },
				{ 4, 8 },
				{ 5, 10 },
				};
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.printf("arr[%d][%d] = %d \t",i,j,arr[i][j]);
//				System.out.print(arr[i][j]+"\t"); //��
			}System.out.println();
		}
	}
}
