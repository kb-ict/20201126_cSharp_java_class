
public class Pulee_mine5 {

	public static void main(String[] args) {
		/*5.	1~100까지 짝수 제외한 합을 구하는 함수를 작성하고, 
		 * 		해당 결과 값이 출력되는 프로그램을 작성하시오.
		 */
		int hap = 0;
		for (int i = 0; i < 100; i++) {
			if((i+1)%2!=0) {
				hap += (i+1);
				}
		}System.out.println("1~100까지 홀수의 합: "+hap);
	}

}
