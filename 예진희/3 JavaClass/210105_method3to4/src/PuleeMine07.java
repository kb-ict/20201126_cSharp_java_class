
public class PuleeMine07 {

	public static void main(String[] args) {

		/*7. 1 ~ 100까지의 합을 구하는 프로그램.
		 * 조건1) 메쏘드에서 짝수들의 합과 홀수들의 합을 배열에 저장.
		 * 조건2) 메쏘드에서 짝수합과 홀수합을 배열에 저장하고 리턴하기.
		 * 조건3) main()에서 메쏘드로부터 배열을 리턴받아 홀수합, 짝수합 출력하기.
		*/
		int arr[] = hap();
		System.out.println("짝수의 합은 "+arr[0]);
		System.out.println("홀수의 합은 "+arr[1]);
	}
	
	public static int[] hap() {
		//for문으로 값 증감, arr 2개 선언 각각 저장?
		int arr[] = new int[2];
		
		for (int i = 0; i < 100; i++) {
			if((i+1)%2==0) {
				arr[0] += (i+1);
			
			}
			
			if((i+1)%2!=0) {
				arr[1] += (i+1);
			
			}
			
		}
		return arr;
	}
}
