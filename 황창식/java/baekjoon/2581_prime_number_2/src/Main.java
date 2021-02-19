import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int m = s.nextInt();
		int n = s.nextInt();
		int arr[] = new int[(n-m)+1];
		boolean result[] = new boolean[arr.length];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = i+m;
		}
		for (int i = 0; i < arr.length; i++) {
			for (int j = 2; j < arr[i]; j++) {
				if(arr[i]%j == 0) {
					result[i] = true;
				}
			}
		}
		int count = 0;
		for (int i = 0; i < result.length; i++) {
			if(result[i] == false) {
				count++;
			}
		}
		if(count == 0 || (m == 1 && n == 1)) {
			System.out.println(-1);
		}
		else {
			int sum = 0;
			int min = 0;
			for (int i = (arr.length-1); i >= 0; i--) {
				if(result[i] == false && arr[i] != 1) {
					sum += arr[i];
					min = arr[i];
				}
			}
			System.out.println(sum);
			System.out.println(min);
		}
		
		
		
	}
}