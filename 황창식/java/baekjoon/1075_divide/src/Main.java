import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int f = s.nextInt();
		int ndiv = n - (n%100);
		while(true) {
			if(ndiv % f != 0) {
				ndiv++;
			}
			else {
				break;
			}
		}
		int a = (ndiv%100)/10;
		int b = ndiv%10;
		
		System.out.println(a + "" + b);

	}

}
