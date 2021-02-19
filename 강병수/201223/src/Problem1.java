
public class Problem1 {

	public static void main(String[] args) {
		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
		int sum = 0;
		for(int i = 0 ; i < arr.length ;i++) {
			sum += arr[i];
		}
		int avr = sum/arr.length;
		System.out.println(sum);
		System.out.println(avr);

	}

}
