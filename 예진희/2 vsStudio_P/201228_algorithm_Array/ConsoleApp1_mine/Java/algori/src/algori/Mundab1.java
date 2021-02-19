package algori;

import java.util.Arrays;
import java.util.Scanner;

public class Mundab1 {

	public static void main(String[] args) {
		// 숫자 N개 입력받아서 작은수 큰수 작은수 출력
		System.out.println("1번 문제");
		Scanner s = new Scanner(System.in);
		System.out.println("총 몇개의 숫자 입력?");
		int countNum = s.nextInt();
		System.out.println("숫자 입력받기");
		int[] numberList = new int[countNum];
		/* int max = numberList[0]; 
		 * int min = numberList[0];
		 */
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//최대 최소 비교
		//1번째 방법
		int max = numberList[0];
		int min = numberList[0];
		
		for (int i = 0; i < numberList.length; i++) {
			if(numberList[i]>max)
				max = numberList[i];
			if(numberList[i]<min)
				min = numberList[i];
		}System.out.println("최솟값 : "+min);
		System.out.println("최대값 : "+max);
		
		//2번째 방법
		Arrays.sort(numberList);
		System.out.println("최솟값: "+numberList[0]);
		System.out.println("최대값: "+numberList[numberList.length-1]);
	}
}
