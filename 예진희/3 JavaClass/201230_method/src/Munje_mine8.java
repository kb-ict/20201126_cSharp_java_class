//패키지 없다.

public class Munje_mine8 {
	/*
	 * 8. 구구단 2~9단까지 전체 출력중에 홀수단만 출력하는 프로그램.
	 * 조건1) 홀수단만 출력하는 메쏘드를 작성.
	 * 조건2) 출력 형식은 다음과 같이.
	 * 3X1=3  5X1=5  7X1=7  9X1=9
	 * 3X2=6  5X2=10 7X2=14 9X2=18
	 *  .      .      .      .
	 *  .      .      .      .
	 *  3X9=27 5X9=45 7X9=63 9X9=81
	*/
	public static void gopagi(int arr[][]) {
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				if((j+2)%2!=0) {
					System.out.printf("%dx%d=%d\t",(j+2),(i+1),(j+2)*(i+1));
					}
				}System.out.println();
			}
	}
	
	public static void main(String[] args) {
	
		int[][] arr = new int[9][8];
		gopagi(arr);
		}
	}
