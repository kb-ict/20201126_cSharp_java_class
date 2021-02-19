package array;

import java.util.Arrays;
import java.util.Scanner;

public class Array_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		/*System.out.print("숫자를 입력하세요(배열 크기) : ");
		int arr[] = new int[s.nextInt()];
		System.out.print("수를 입력하세요 : ");
		
		for(int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
						
		}
		int max = arr[0];
		int min = arr[0];
		int maxnum = 0;
		int minnum = 0;
		 for(int i = 0; i < arr.length; i++) {
			if(max < arr[i]) {
				max = arr[i];
				maxnum = i+1;
			}
			else if(max == arr[0]) {
				maxnum = 1;
			}
			if(min > arr[i]) {
				min = arr[i];
				minnum = i+1;
			}
			else if(min == arr[0]) {
				minnum = 1;
			}
			
		}
			
		System.out.println("최댓값 : " + max + "(" + maxnum + "번째)");
		System.out.println("최솟값 : " + min + "(" + minnum + "번째)");*/
		
		System.out.println("1번 문제");
		System.out.print("몇개의 숫자를 받을래? : ");
		int countnum = s.nextInt();
		System.out.print("숫자 입력해라 : ");
		int numberList[] = new int[countnum];
		
		for (int i = 0; i < countnum; i++) {
			numberList[i] = s.nextInt();
		}
		
		// 배열에 값을 다 입력한 뒤에 최대, 최소값을 초기화
		int max = numberList[0];
		int min = numberList[0];
		int maxnum = 1;
		int minnum = 1;
		for (int i = 0; i < numberList.length; i++) {
			if(numberList[i] > max) {
				max = numberList[i];
				maxnum = i + 1;
			}
			if(numberList[i] < min) {
				min = numberList[i];
				minnum = i + 1;
			}
		}
		System.out.println("최소값 : " + min + " (" + minnum + "번째)");
		System.out.println("최대값 : " + max + " (" + maxnum + "번째)");
		
		// 두번째 방법
//		Arrays.sort(numberList);
//		System.out.println("최소값 : " + numberList[0]);
//		System.out.println("최대값 : " + numberList[numberList.length-1]);
//		
		
		
		s.close();
		
		
		
		
		
		

	}

}
