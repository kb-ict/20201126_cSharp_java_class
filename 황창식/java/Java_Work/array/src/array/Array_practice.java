package array;

import java.util.Random;

public class Array_practice {

	public static void main(String[] args) {
	
		// 1. 배열의 총 합과 평균
		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
		int sum = 0;
		for(int i = 0; i < 10; i++) {
			sum += arr[i];
		}
		System.out.println("배열의 총 합 : " + sum);
		System.out.println("배열의 평균  : " + (sum / 10));
				
				
		// 2. 5의 배수와 90번째 일때 출력 중지
		/*int[] array = new int[101];
		
		for(int i = 1; i <= 100; i++) {
			array[i] = i;
			// System.out.println("array[" + i + "] = " + array[i]);
			if((array[i] % 5) == 0 && i <= 90){
				System.out.println("array[" + i + "] = " + array[i]);
			}
		}*/
				
				
		// 3.
		/*int arr[] = new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
		int arr2[] = new int [10];
		for(int i = 0; i < 10; i++) {
			for(int j = 9; j>=0; j--) {
				arr2[i] = arr[j];
				System.out.println(arr2[i]);
			}
			break;
		}*/
		
		
		// 4.
		/*int arr[][] = {{1, 2}, {2, 4, 6}, {3, 6},{4, 8, 10, 12}, {10}};
		
		for(int i=0;i<arr.length; i++) {
			for(int j = 0; j < arr[i].length;j++) {
				System.out.printf("arr[%d][%d] = %d\t", i, j, arr[i][j]);
			}
			System.out.println();
		}*/
		
		
		// 5.
		/*int[][] arr = new int[][] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};	
		int[][] arr2 = new int[][] {{10, 20, 30}, {40, 50, 60}, {70, 80, 90}};
		int[][] arr3 = new int[3][3];
		for(int i = 0; i < arr.length; i++) {
			for(int j = 0; j < arr[i].length; j ++) {
				arr3[i][j] = arr[i][j] + arr2[i][j];
				System.out.print(arr3[i][j] + "	");
			}
			System.out.println();
			
		}*/
		
		
		// 6.
		/*int[][] arr = new int[9][8];
		
		for(int i = 0; i < arr.length; i++) {
			for(int j = 0; j < arr[i].length; j++) {
				arr[i][j] = (j+2) * (i+1);
				System.out.printf("%d x %d = %d\t",j+2,i+1,arr[i][j]);
			}
			System.out.println();
		}*/
		
		
		// 7.
		/*String last[] = {"김", "박", "이", "최", "장"};
		String first[] = {"바", "사", "아", "자", "차"};
		String mid[] = {"가", "나", "다", "라", "마"};
		
		Random rand = new Random();
		
		
		String[] fullname = new String[50];
		
		for(int i = 0; i < fullname.length; i++) {
			int num1 = rand.nextInt(5);
			int num2 = rand.nextInt(5);
			int num3 = rand.nextInt(5);
			fullname[i] = last[num1] + first[num2] + mid[num3];
			System.out.println(fullname[i]);
		}*/
		
		// 8.
		/*Random rand = new Random();
		int[] arr = new int[6];
		
		for(int i = 0; i < 6; i++) {
			arr[i] = rand.nextInt(45) + 1;
			for(int j = 0; j < i; j++) {
				arr[j] = rand.nextInt(45) + 1;
				if(arr[i] == arr[j]) {
					i--;
					
				}
			}
			System.out.print(arr[i] + " ");
		}*/}

}
