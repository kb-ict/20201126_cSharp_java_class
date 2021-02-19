package beak;

import java.util.Scanner;

public class Beak2292 {

	public static void main(String[] args) {
		
		Scanner sc= new Scanner(System.in);
		
		int num=sc.nextInt();
		int temp=1;
		if (num>=2&&num<=7) {
			System.out.println(2);
		}
		else if (num>7) {
			while (num>=(temp*6)+1) {
				temp++;
			}
				System.out.println(temp);	
		} 	
		else  {
			System.out.println(1);
		}
		
	}

}
