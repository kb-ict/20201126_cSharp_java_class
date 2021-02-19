package loop_20201216;

public class Loop8 {

	public static void main(String[] args) {

		int hap = 0;
		for (int i = 1; i <= 10; i++) {
			if (i % 3 == 0) {
				continue; 
			}

			if (i == 5) {
				System.out.println("탈출");
				break; 
			}
			hap += i + 1;
			System.out.println("i + 1 = " + (i + 1));
		}
		System.out.println("1 ~ 10중 3의 배수를 제외한 모든 수의 합 : " + hap);

	}

}
