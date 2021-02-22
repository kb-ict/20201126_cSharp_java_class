import java.util.Scanner;

public class Ex031 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int A = s.nextInt();
		int B = s.nextInt();
		int C = s.nextInt();
		String D ="";
		D=D+(A*B*C);
		int[] count = new int[10];
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < D.length(); j++) {
				if(D.charAt(j)-'0'==i) {
					count[i]++;
					continue;
				}
			}
			System.out.println(count[i]);
		}				
		s.close();	
	}

}
