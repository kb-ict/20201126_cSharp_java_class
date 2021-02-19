
public class MethodYeje3 {
	public static int[] makeArray() {// 3 배열 먼저만들고 메인에서 사용
		int arr[] = new int[3];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = 100 + i;
		}
		return arr; // 배열의 주소값, 메소드랑 클래스 동일하게 던져줄 수 있음
	}

	public static void main(String[] args) {
		int arr[] = makeArray();

		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
}
