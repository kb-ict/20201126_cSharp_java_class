package loop_20201216;

public class Loop3 {

	public static void main(String[] args) {

		int hap = 0;
		for (int i = 0; i < 10; i += 2) {
			hap += (i + 1);
		}
		System.out.println("1~10 홀수의 합1 : " + hap);

		hap = 0;
		for (int j = 0; j < 10; j++) {
			if ((j + 1) % 2 == 1) {
				hap += (j + 1);
			}

		}
		System.out.println("1~10 홀수의 합2 : " + hap);
	}

}
