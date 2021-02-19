import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[] = new int[s.nextInt()];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		for (int i = 0; i < arr.length; i++) {
			arr[i] = calc(arr[i]);
			System.out.println(arr[i]);
		}
		
	
	}
	
	public static int calc(int num) {
		switch(num) {
		case 1:
			return 1;
		case 2:
			return 2;
		case 3:
			return 4;
		default :
			return calc(num-1) + calc(num-2) + calc(num-3);
			
		}
	}

}
