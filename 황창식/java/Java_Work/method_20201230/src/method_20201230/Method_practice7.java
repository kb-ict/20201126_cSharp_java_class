package method_20201230;

public class Method_practice7 {

	public static void main(String[] args) {
		int result[] = holjjacksum();
		System.out.println("1~100 홀수의 합 : " + result[0]);
		System.out.println("1~100 짝수의 합 : " + result[1]);
	}

	public static int[] holjjacksum() {
		int holsum = 0;
		int jjacksum = 0;
		for (int i = 0; i < 100; i++) {
			if ((i + 1) % 2 == 0) {
				jjacksum += i + 1;
			} 
			else if ((i + 1) % 2 == 1) {
				holsum += i + 1;
			}
		}
		int result[] = { holsum, jjacksum };
		return result;
	}

}
