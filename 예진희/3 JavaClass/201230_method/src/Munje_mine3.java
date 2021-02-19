//패키지 없다.

public class Munje_mine3 {
	/*	
	 * 3. 홀수, 짝수 구분하는 프로그램.
	 * 조건1) 10개의 숫자를 저장하기위한 배열 생성.
	 * 조건2) 랜덤하게 10개의 숫자를 main()에서 배열에 저장.
	 * 조건3) 랜덤한 값을 가지는 배열을 매개변수로 전달하여 홀,짝수를 구분하는 메쏘드 작성.
	*/	
	public static void holJjack(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			if (arr[i]%2==0) {
				System.out.printf("%d번째 arr[%d]의 값 %d는 짝수입니다.\n",(i+1),i,arr[i]);
			}else {
				System.out.printf("%d번째 arr[%d]의 값 %d는 홀수입니다.\n",(i+1),i,arr[i]);
			}
			
		}
	}
	
	public static void main(String[] args) {
		int arr[] = new int[10];
		System.out.println("1. 배열 10개 생성, 랜덤 수를 저장합니다\n---------------------------");
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)(Math.random()*10)+1;
			System.out.printf("%d번째 arr[%d]의 수 : %d\n",(i+1),i,arr[i]);
		}
		System.out.println("\n2. 배열 10개의 랜덤 수를 판단합니다.\n---------------------------");
		holJjack(arr);
	}

}



/*검증 1~3까지 랜덤 수 생성-----------------------
 * for (int i = 0; i < 3; i++) { 
 * int num = (int)(Math.random()*3)+1;
 * System.out.print(num+"  "); 
 * }
 * 
 */

/*10번수행 및 1~10까지 랜덤수 확인-----------------
 * for (int i = 0; i < arr.length; i++) {
 * 			arr[i] = (int)(Math.random()*10)+1;
 * 			System.out.println("arr "+(i+1)+"번째: "+arr[i]);
		}
 */
