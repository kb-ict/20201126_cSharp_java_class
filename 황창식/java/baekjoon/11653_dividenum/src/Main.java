import java.util.ArrayList;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		ArrayList<Integer> div = new ArrayList<Integer>();
		for (int i = 2; i < n; i++) {
			if(n%i == 0) {
				div.add(i);
			}
		}
	}
}
