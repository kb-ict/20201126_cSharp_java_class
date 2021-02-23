import java.util.Random;

public class Problem11 {

	public static int[][] grade() {
		Random ran = new Random();
		int arr[][] = new int[5][3];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = ran.nextInt(101);
			}
		}
		return arr;
	}

	public static void main(String[] args) {
		int Arr[][] = grade();
		int sum = 0;
		double avr = 0;

		for (int i = 0; i < Arr.length; i++) {
			for (int j = 0; j < Arr[i].length; j++) {
				sum = sum + Arr[i][j];
				avr = (double) sum / 3;
			}
			System.out.printf("학생%d의 총점: %d\n", (i + 1), sum);
			System.out.printf("학생%d의 평균: %f\n", (i + 1), avr);
			if (avr >= 90 && avr <= 100) {
				System.out.printf("학생%d의 학점: A\n", (i + 1));
			} else if (avr >= 80 && avr < 90) {
				System.out.printf("학생%d의 학점: B\n", (i + 1));
			} else if (avr >= 70 && avr < 80) {
				System.out.printf("학생%d의 학점: C\n", (i + 1));
			} else if (avr >= 60 && avr < 70) {
				System.out.printf("학생%d의 학점: D\n", (i + 1));
			} else if (avr >= 50 && avr < 60) {
				System.out.printf("학생%d의 학점: E\n", (i + 1));
			} else if (avr >= 0 && avr < 50) {
				System.out.printf("학생%d의 학점: F\n", (i + 1));
			}
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			sum = 0;
			avr = 0;
		}

	}

}
