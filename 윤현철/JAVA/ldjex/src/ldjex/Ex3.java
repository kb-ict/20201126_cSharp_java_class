package ldjex;

import java.util.Scanner;

public class Ex3 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int a = s.nextInt();
		for(int i=0;i<a;i++) {
			for(int j=i;j<a;j++) {
				System.out.print(" ");
			}
			for(int k=((i+1)*2)-1;k>0;k--) {
				System.out.print("*");
			}
			System.out.println("");
		}
		s.close();
	}

}
