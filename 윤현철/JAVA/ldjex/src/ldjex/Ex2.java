package ldjex;

import java.util.Scanner;

public class Ex2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int t = s.nextInt();
		int a;
		int b;
		a=t/60;
		b=t%60;
		System.out.printf("%d분 %d초",a,b);
		s.close();		
	}

}
