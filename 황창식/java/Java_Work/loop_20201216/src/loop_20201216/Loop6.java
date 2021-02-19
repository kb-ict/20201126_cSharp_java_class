package loop_20201216;

public class Loop6 {

	public static void main(String[] args) {

		int hap = 0;
		int i = 0;
		while (i < 10) {
			hap += i + 1;
			i++;
		}
		System.out.println("1 ~ 10 까지의 합1 : " + hap);

		hap = 0;
		i = 0;
		do {
			hap += i + 1;
			i++;
		} while (i < 10);
		System.out.println("1 ~ 10 까지의 합2 : " + hap);
	}

}
