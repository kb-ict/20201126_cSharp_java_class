import java.util.Scanner;

public class Ex032 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] A = new int[10];
		int con = 0;
		for (int i = 0; i < 10; i++) {
			A[i]= s.nextInt();
			A[i]= A[i]%42;
		}
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < i; j++) {
				if(A[i]==A[j]) {
					con--;
					break;
				}
				
			}
			con++;
		}
		System.out.println(con);
		s.close();
	}

}
