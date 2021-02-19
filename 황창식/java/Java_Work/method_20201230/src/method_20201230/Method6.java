package method_20201230;

public class Method6 {
	public static void func(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
	
	public static void func2(int arr[][]) {
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + " ");
			}
			System.out.println();
		}
	}
	
	public static void main(String[] args) {
		int arr[] = {1, 2, 3, 4, 5};
		System.out.println("arr (1차원 배열)");
		func(arr);
		
		int arr2[][] = {{1, 2, 3}, {4, 5, 6}};
		System.out.println("\narr2 (2차원 배열)");
		func2(arr2);
	}
}
