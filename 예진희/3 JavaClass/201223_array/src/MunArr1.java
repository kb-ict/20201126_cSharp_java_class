
public class MunArr1 {

	public static void main(String[] args) {
//		1. 다음 1차원 배열의 합과 평균을 구하세요
//		조건1) 배열 초기값
//		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25,  99, 88};
		double hap = 0;
		double ave = 0;
		int arr[] = { 20, 34, 22, 14, 36, 23, 67, 25, 99, 88 };
		for (int i = 0; i < arr.length; i++) {
			hap = hap + arr[i];
			ave = hap/arr.length;
		}
		System.out.printf("배열의 총 합은 %d이다.\n",(int)hap);
		System.out.printf("배열의 평균은 %.1f이다.",ave);
	}
}
