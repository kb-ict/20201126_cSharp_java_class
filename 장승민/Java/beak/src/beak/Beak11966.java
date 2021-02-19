package beak;

import java.util.Scanner;

public class Beak11966 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		sc.close();
		while (num > 2) {
			if (num % 2 == 0) {
				num=num/2;
			}else break;
				
		}
		if(num==1||num==2)System.out.println(1);
		else System.out.println(0);
	}
}
