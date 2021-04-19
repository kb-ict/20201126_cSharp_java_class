public class Problem3 {

	public static void main(String[] args) {
		int arr[] = new int[10];
		for (int i = 0; i < 10; i++) {
			arr[i] = (int) (Math.random() * 1000) + 1;
		}
		odd(arr);

	}

	public static void odd(int arr[]) { //홀짝 구분하는 메소드
		for (int i = 0; i < 10; i++) {
			if (arr[i] % 2 == 0) {
				System.out.println("짝수");
			} else {
				System.out.println("홀수");
			}
		}
	}

}
