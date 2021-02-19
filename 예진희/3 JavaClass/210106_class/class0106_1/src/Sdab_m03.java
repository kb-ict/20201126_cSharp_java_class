import java.util.Random;
public class Sdab_m03 {

	public static void main(String[] args) {
		/*3. 홀수, 짝수 구분하는 프로그램.
		 * 조건1) 10개의 숫자를 저장하기위한 배열 생성.
		 * 조건2) 랜덤하게 10개의 숫자를 main()에서 배열에 저장.
		 * 조건3) 랜덤한 값을 가지는 배열을 매개변수로 전달하여 
		 * 홀,짝수를 구분하는 메쏘드 작성.
		 */
		
		int arr[] = new int[10];
		/*첨자, 인덱스, 가변적으로 배열크기 조정 가능 ----
		 *int a= 10;
		 *int arr[] = new int[a];
		 */
		
		Random rand = new Random();
		System.out.println("메인에서 랜덤숫자 생성");
		for (int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(100); //0~99
			//System.out.println((i+1)+"번째 숫자: "+arr[i]);
		}
		evenOdd(arr);
	}
	public static void evenOdd(int arr[]) {//매개변수  1차원 배열로 받음
		for (int i : arr) {
			if(i%2!=0) {
				System.out.println(i+" = 홀수");
			}
			
			if(i%2==0) {
				System.out.println(i+" = 짝수");
			}
		}
	}
}
