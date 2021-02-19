import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[] = new int[s.nextInt()];
		int k = s.nextInt();
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		
		int count = 0;
		int result = 0;
		for (int i = arr.length-1; i >= 0; i--) {
			int coincount = 0;
			if(arr[i] <= k) {
				while(true) {
					if(result + (arr[i]*coincount) <= k) {
						coincount++;
					}
					else {
						coincount--;
						break;
					}
				}
			}
			result += arr[i]*coincount;
			count += coincount;
		}
		System.out.println(count);

	}

}
