import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		boolean checker[] = new boolean[n];
		for (int i = 0; i < n; i++) {
			String str = s.next();
			checker[i] = wordChecker(str);
		}
		int count = 0;
		for (int i = 0; i < checker.length; i++) {
			if (checker[i] == true) {
				count++;
			}
		}
		System.out.println(count);
	}

	public static boolean wordChecker(String str) {
		boolean checker = true;
		char ch[] = str.toCharArray();
		for (int i = 0; i < ch.length; i++) {
			int count = 1;
			for (int j = i + 1; j < ch.length; j++) {
				if (ch[i] == ch[j]) {
					count++;
				}
			}
			if (count > 1) {
				if (ch[i] != ch[i + 1]) {
					checker = false;
					break;
				}
			} else {
				checker = true;
			}
		}
		return checker;
	}

}
