import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int arr[] = new int[n];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		boolean result[] = new boolean[n];
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 2; j < arr[i]; j++) {
				if(arr[i]%j == 0)
					result[i] = true;
			}
		}
		int count = 0;
		
		for (int i = 0; i < result.length; i++) {
			if (result[i] == false && arr[i] != 1) {
				count++;
			}
			
		}
		
		System.out.println(count);
		
	}

}
