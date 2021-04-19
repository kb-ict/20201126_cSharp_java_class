public class Problem7 {

	public static int[] odd() {
		int odd[] = new int[100];
		int sum1 = 0;
		for (int i = 0; i < odd.length; i++) {
			if (i % 2 == 1) {
				odd[i] = i;
				sum1 += i;
			}
		}
		return odd;
	}

	public static int[] even() {
		int even[] = new int[101];
		int sum2 = 0;
		for (int i = 0; i < even.length; i++) {
			if (i % 2 == 0) {
				even[i] = i;
				sum2 += i;
			}
		}
		return even;
	}

	public static void main(String[] args) {
		int odd[] = odd();
		int even[] = even();
		int sum1 = 0;
		int sum2 = 0;
		for (int i = 0; i < odd.length; i++) {
			sum1 = sum1 + odd[i];
		}
		for (int j = 0; j < even.length; j++) {
			sum2 = sum2 + even[j];
		}
		System.out.println("홀수의 합: " + sum1);
		System.out.println("짝수의 합: " + sum2);

	}

}
