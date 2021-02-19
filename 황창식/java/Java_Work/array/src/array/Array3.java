package array;

public class Array3 {

	private static int sumOfAry(int[] arr6) {
		int sum = 0;
		for(int i = 0; i < arr6.length; i++) {
			sum += arr6[i];
		}
		return sum;
	}

	public static void main(String[] args) {

		// 배열을 생성과 동시에 초기화
		int[] arr1 = new int[3];
		int[] arr2 = new int[] { 1, 2, 3 };
		int[] arr3 = { 1, 2, 3 };
		// 모두 길이가 3인 배열 생성

		// 참조변수의 2가지 선언방법
		int[] arr4 = new int[3];
		int arr5[] = new int[3];

		int[] arr6 = { 1, 2, 3, 4, 5, 6, 7 };
		int sum = sumOfAry(arr6);
		System.out.println(sum);
	}

}
