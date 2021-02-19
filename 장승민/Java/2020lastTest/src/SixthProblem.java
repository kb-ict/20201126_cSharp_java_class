import java.util.Scanner;

public class SixthProblem {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N =sc.nextInt();
		int M =sc.nextInt();
		int sum = 0;
		for (int i = 1; i < N+1; i++) {
			if (i%M!=0) {
				sum=sum+i;
				}
		}
		System.out.println(sum);
		
	}

}
