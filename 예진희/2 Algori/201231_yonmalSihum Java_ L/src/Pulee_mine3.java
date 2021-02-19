
public class Pulee_mine3 {

	public static void main(String[] args) {
		/*3. 아래와 같은 출력 형태의 구구단을 출력하는 프로그램을 작성하시오. 
		 * 2x1=2
		 * 2x2=4
		 * ...
		 * 9x8=72
		 * 9x9=91
		 */
		
		//{2~9 = 8행(i), { 1~9 = 9열(j) 줄바꿈}}
		for (int i = 0; i < 8; i++) {
			for (int j = 0; j < 9; j++) {
				System.out.printf("%dx%d=%d\n",(i+2),(j+1),(i+2)*(j+1));
			}
		}
		
		
	}
}
