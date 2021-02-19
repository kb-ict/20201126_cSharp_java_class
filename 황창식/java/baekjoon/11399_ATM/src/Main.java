import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int arr[] = new int[n];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		
		Arrays.sort(arr);
		
		int count1 = 0;
		int count2 = 0;
		for (int i = 0; i < arr.length; i++) {
			count1 += arr[i];
			count2 += count1;
		}
		System.out.println(count2);

	}

}
