
public class MunArr2 {

	public static void main(String[] args) {
//		2. 1 ~ 100까지의 수를 1차원 배열에 저장.
//		조건1) 저장된 배열에서 5의 배수만 출력하세요.
//		조건2) 배열의 위치가 90번째 일때 출력을 중지함.
		
		int[] arr = new int[100];
		for (int i = 0; i < arr.length; i++) {
			arr[i]=(i+1);
			
			if (arr[i]%5==0) {
				System.out.println(arr[i]);
			}
			
			if (arr[i]==89) {
				System.out.println("배열주소 90번째에서 프로그램 종료");
				break;
			}
			
		}
	}
}