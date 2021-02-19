
public class MunArr3 {

	public static void main(String[] args) {
//		3. 아래의 데이터를 새로운 배열에 저장한후, 출력하세요.
//
//		조건1) 배열 초기값
//		int arr[] = new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
//		조건2) 새로운 배열을 생성하고 100, 90, 80 순으로 저장하여 출력.

		int arr[] = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
		int arr2[] = new int[10];
		
		for (int i = 0; i < arr.length; i++) {
			arr2[i] = 100-(i*10);
			System.out.print(arr2[i]+", ");
		}
	}
}