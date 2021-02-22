import java.util.Scanner;

public class Ex033 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		double[] a= new double[N];
		for (int i = 0; i < N; i++) {
			a[i]=s.nextInt();
		}
		double M = a[0];
		double sum=0;
		for (int i = 0; i < N; i++) {
			if(M<a[i]) {
				M=a[i];
			}
		}
		for (int i = 0; i < N; i++) {
			a[i]=(a[i]/M)*100;
			sum=sum+a[i];
		}
		System.out.println(sum/N);
		s.close();
	}
}
