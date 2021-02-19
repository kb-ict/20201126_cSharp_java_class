
public class ArrYeje2 {

	public static void main(String[] args) {
		int arr[][]= new int[4][3]; // 선언된 범위(중괄호{})안에서 변수 사용가능 
		int value = 1; //break point, 7번까지만 실행 및 중단
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				arr[i][j] = value++; //전부 100이라고 들어감
				System.out.println("디버깅: "+arr[i][j]);
			}
		}
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
	}
}
