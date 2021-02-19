
public class Pulee_mine4 {

	public static void main(String[] args) {
		/*4. 5층 별나무 피라미드
		 * ---*
		 * --***
		 * -*****
		 * 
		 * (복습하기)
		 * 풀긴했는데 콘솔 돌리면서 확인한거라 
		 * 로직은 따로한번 더 봐야함 ㅡㅡ;; 
		 */
		
		for (int i = 0; i < 5; i++) {
			for (int j = i; j < 4; j++) {
				System.out.print(" ");
			}
			for (int j = 0; j < (2*i)+1; j++) {
				System.out.print("*");
			}
			System.out.println();
		}
	}
}
