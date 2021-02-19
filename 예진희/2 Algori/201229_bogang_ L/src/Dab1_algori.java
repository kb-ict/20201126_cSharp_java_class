import java.util.Scanner;

public class Dab1_algori {

	public static void main(String[] args) {
		String line = "--------------------------";
		/*
		 * 정한수 숫자 입력받기 최소, 최대값 출력
		 * 
		 * 1. 총 입력받을 수 정하기 2. 입력숫자 크기의 배열선언 3. 배열에 숫자 저장 4. 배열 안에서 최대, 최소값 출력
		 * 
		 * index : 색인, 배열값의 위치(주소)
		 */

		// 1. 총 입력받을 수 정하기
		System.out.print("배열의 크기를 정하세요: ");
		int countNum = 0;
		Scanner s = new Scanner(System.in);
		countNum = s.nextInt();
		System.out.println(line);

		// 2. 입력숫자 크기의 배열선언
		int[] input = new int[countNum];
//		int max = input[0]; //여기에 넣으면 xx
//		int min = input[0];

		// 3. 배열에 숫자 저장
		for (int i = 0; i < input.length; i++) {
			System.out.print((i + 1) + "번째 수 입력: ");
			input[i] = s.nextInt();
		}
		// 최대, 최소값 저장할 변수 만듦
		int max = input[0];
		int min = input[0];

		// 4. 배열안에서 최대, 최소값 출력
		for (int i = 0; i < input.length; i++) {
			//----- 답 -----------------------
//			if (max < input[i])
//				max = input[i];
//			if (min > input[i])
//				min = input[i];
			
			//-------------------------------
			if (max < input[i])
				max = input[i];
			else if (min > input[i])
				min = input[i];
			
			if (max < input[i])
				max = input[i];
			else min = input[i];
			//-------------------------------
			
		}
		System.out.println(line+"\n최대값은 " + max + ", 최솟값은 " + min);

		// -------- 내 풀이 ---
//		for (int i = 0; i < input.length; i++) {
//			if (max < input[i]) {
//				max = input[i];
//			}
//
//			if (min > input[i]) {
//				min = input[i];
//			}
//		}
//		System.out.println(line+"\n최대값은 " + max + ", 최솟값은 " + min);

		s.close();

	}

}
