import java.util.Scanner;

public class Problem5 {

	public static void main(String[] args) {
		int arr[] = new int[26];
		char alp[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x', 'y', 'z' };
		Scanner sc = new Scanner(System.in);
		String alpha = sc.next();

		for (int i = 0; i < alp.length; i++) {
			for (int j = 0; j < alpha.length(); j++) {
				if (alp[i] == alpha.charAt(j)) {
					arr[i]++;
				}

			}

		}

		for (int k = 0; k < arr.length; k++) {
			if (arr[k] == 0) {
				continue;
			}
			System.out.println("'" + alp[k] + "'" + "는" + arr[k] + "글자입니다.");
		}
		sc.close();
	}

}
