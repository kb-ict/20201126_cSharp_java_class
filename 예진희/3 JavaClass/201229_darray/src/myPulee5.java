public class myPulee5 {// 5번 문제

	public static void main(String[] args) {
		int value = 1;
		int[][] arr1 = new int [3][3];
		System.out.println("arr1의 배열\n--------------------");
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1[i].length; j++) {
				arr1[i][j] = value++;
				System.out.print(arr1[i][j]+"\t");
			}System.out.println();
		}
		System.out.println();
		System.out.println("arr2의 배열\n--------------------");
		int[][] arr2 = new int[3][3];
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1[i].length; j++) {
				arr2[i][j] = (arr1[i][j])*10;
				System.out.print(arr2[i][j]+"\t");
			}System.out.println();
		}
		
		System.out.println();
		System.out.println("arr2-2의 배열\n--------------------");
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2.length; j++) {
				arr2[i][j] = arr1[i][j]+arr2[i][j];
				System.out.print(arr2[i][j]+"\t");
			}System.out.println();
		}
	}
}
