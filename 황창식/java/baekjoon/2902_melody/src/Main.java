import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[] = new int[8];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		String str[] = new String[8];
		for (int i = 0; i < str.length; i++) {
			str[i] = Integer.toString(arr[i]);
		}
		String fullnum = "";
		for (int i = 0; i < str.length; i++) {
			fullnum += str[i];
		}
		if(fullnum.equals("12345678")) {
			System.out.println("ascending");
		}
		else if(fullnum.equals("87654321")) {
			System.out.println("descending");
		}
		else {
			System.out.println("mixed");
		}
	}
}
