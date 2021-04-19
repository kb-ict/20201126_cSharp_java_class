
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
		int arr[] = { 1, 2, 3, 4, 5 };
		func(arr);
		System.out.println("\n2차원 배열");
		int arr2[][] = { { 1, 2, 3 }, { 4, 5, 6 } };
		func2(arr2);
	}
}
