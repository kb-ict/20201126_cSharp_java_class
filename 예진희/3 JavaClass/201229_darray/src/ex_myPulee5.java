public class ex_myPulee5 {// 5번 문제

	public static void main(String[] args) {
		int value = 1;
		int[][] arr1 = new int[3][9];
		int i = 0;
		int j = 0;
		System.out.println("arr1의 배열\n--------------------");
		for (i = 0; i < arr1.length; i++) {
			
			for (j = 0; j < arr1[i].length; j++) {
				arr1[i][j] = value++;
				if((j+1)%3==0) {
					System.out.print(arr1[i][j] + "\t"+"\t");
				}
				else {
					System.out.print(arr1[i][j] + "\t");
				}
				
			}

			System.out.println();
		}
	}
}

//if (j==arr1[i].length-1) {
//	System.out.println("\t"+(arr1[i][j]*10)+"  ");
//}
