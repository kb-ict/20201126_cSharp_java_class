package method_201230;

import java.util.Random;


public class MethodPractice3 {

	public static void main(String[] args) {
		
		Random rd = new Random();
		
		int arr[] = new int [10];		//10개의 수를 입력받기 위한 배열 생성
		for (int i = 0; i < arr.length; i++) {
			arr[i]=(rd.nextInt(100)+1);	//10개의 인덱스에 1~100까지의 랜덤한 수 입력
		}
		func(arr);						//메쏘드 호출

	}
	
	public static void func(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			if (arr[i]%2==0) {
				System.out.println(arr[i]+" 짝수");	//각 인덱스의 수들을 홀 짝 구분하여 해당하는 수와 홀,짝 결과 출력
			}
			else {
				System.out.println(arr[i] +" 홀수");
			}
		}
	}
}

