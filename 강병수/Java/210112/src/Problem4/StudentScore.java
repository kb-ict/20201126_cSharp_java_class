package Problem4;

public class StudentScore {

	int sum;
	double avr;
	int [][] arr;
	int [] Sum;
	double [] Avr;
	char [] Grade;

	public StudentScore(int[][] arr) {
		this.arr = arr;
		Sum();
		Avr();
		Grade();
	}

	public void Sum() {
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				sum += arr[i][j];
				Sum[i] = sum;
			}
			System.out.printf("학생%d의 총점: %d\n", i, Sum[i]);
			sum = 0;
		}
	}

	public void Avr() {
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				avr = (double) Sum[i] / 3;
				Avr[i] = avr;
			}
			System.out.printf("학생%d의 평균: %d\n = ", i, Avr[i]);
			avr = 0;
		}
	}

	public void Grade() {
		for (int i = 0; i < arr.length; i++) {
			if (avr >= 90 && avr <= 100) {
				Grade[i] = 'A';
			} else if (avr >= 80 && avr < 90) {
				Grade[i] = 'B';
			} else if (avr >= 70 && avr < 80) {
				Grade[i] = 'C';
			} else if (avr >= 60 && avr < 70) {
				Grade[i] = 'D';
			} else if (avr >= 50 && avr < 60) {
				Grade[i] = 'E';
			} else if (avr >= 0 && avr < 50) {
				Grade[i] = 'F';
			}
			System.out.printf("학생%d의 총점: %s\n", i, Grade[i]);
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		}

	}
}