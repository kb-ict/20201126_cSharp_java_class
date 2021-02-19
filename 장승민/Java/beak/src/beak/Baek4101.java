package beak;

import java.util.Scanner;

public class Baek4101 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int a,b ;
		
		while (true) {
			a=sc.nextInt();
			b=sc.nextInt();
			if (a > b) {
				System.out.println("Yes");
			} else if(a<=b&&a!=0||b!=0){
				System.out.println("No");
			} if (a==0&&b==0) {
				break;
			}
		}
		sc.close();
	}

}
