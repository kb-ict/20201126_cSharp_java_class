import java.util.Scanner;

public class Ex034 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int k = s.nextInt();
		String a[]=new String[k];
		for (int i = 0; i < k; i++) {
			a[i]=s.next();
			int sum=0;
			int con=0;
			for (int j = 0; j < a[i].length(); j++) {
				if(a[i].charAt(j)=='O') {
					con++;
				}
				else {
					con=0;
				}
				sum=sum+con;
			}
			System.out.println(sum);
			
		}		
		s.close();
	}

}
