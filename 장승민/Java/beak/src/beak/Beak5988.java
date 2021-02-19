package beak;

import java.util.Scanner;
// 런타임에러(inputMissMatch)
public class Beak5988 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		for (int i = 0; i < num; i++) {
			String N= sc.next();
			
			char[] ch = N.toCharArray();
			
			int last = Integer.parseInt(String.valueOf(ch[(ch.length-1)]));
			if (last%2!=0) {
				System.out.println("odd");
			}else {System.out.println("even");}
		}
		sc.close();
	}

}
