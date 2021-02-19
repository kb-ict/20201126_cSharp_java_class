import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true) {
			int n = s.nextInt();
			if(n == 0) {
				System.exit(0);
			}
			else {
				long arr[] = new long [(2*n-n)+1];
				for (int i = 0; i < arr.length; i++) {
					arr[i] = i + n;
				}
				boolean[] primenum = new boolean[arr.length];
				primenum[0] = true;
				for (int i = 1; i < arr.length; i++) {
					for (int j = 2; j < arr[i]; j++) {
						if(arr[i]%j == 0)
							primenum[i] = true;
					}
				}
				long count = 0;
				for (int i = 0; i < primenum.length; i++) {
					if (primenum[i] == false && arr[i] != 1) {
						count++;
					}
				}
				System.out.println(count);
			}
		}
	}
}
