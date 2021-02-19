import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[][] = new int[s.nextInt()][];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < i; j++) {
				arr[i][j] = s.nextInt();
			}
		}
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				System.out.print(arr[i][j] + " ");
			}
			System.out.println();
		}
		
//		int sum = 0;
//		for (int i = 0; i < arr.length; i++) {
//			int max = arr[i][0];
//			int sumnum = 0;
//			for (int j = 0; j < arr[i].length-i; j++) {
//				if(max < arr[i][j]) {
//					max = arr[i][j];
//				}
//				else if(arr[i][j] < max && (arr[i+2][j] >= max || arr[i+2][j+1] >= max)) {
//					max = arr[i][j];
//				}
//			}
//			sum+=max;
//		}
//		System.out.println(sum);
		

	}

}
