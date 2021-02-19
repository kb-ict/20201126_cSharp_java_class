
public class Arr4 {

	public static void main(String[] args) {
		int arr[] = new int[10]; // 인트형 빈 배열이 10크기로 만들어짐, 0값으로 10개 0,0,0,0,0, 0,0,0,0,0

		for (int i = 0; i < arr.length; i++) {
			arr[i] = i; // 위치접근 arr[0], 마지막 방 arr[n-1] = arr[9]
		  // System.out.println(i);
		} // i는 첫번째 for구문안에서 끝남. 다음i는 다른 변수임

		for (int i = 0; i <= arr.length; i++) {
			System.out.println(arr[i]);
			// 배열범위 벗어남 오류메시지 (Exception in thread "main"
			// java.lang.ArrayIndexOutOfBoundsException: Index 10 out of bounds for length
			// 10 at Arr4.main(Arr4.java:13))

		}
	}
}
