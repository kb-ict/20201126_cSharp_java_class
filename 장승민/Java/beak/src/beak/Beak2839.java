package beak;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Beak2839 {

	public static void main(String[] args) throws IOException {
//		Scanner sc = new Scanner(System.in);
//		int sugar = sc.nextInt();
//
//		int five = sugar / 5;
//		int fifth = sugar % 5;
//		int three = fifth / 3;
//		int third = fifth % 3;
//
//		for (int i = 0; i < third; i--) {
//			if (third != 0) {
//				five = five - 1;
//				fifth = fifth + 5;
//				third = fifth % 3;
//				three = fifth / 3;
//				if (five < 0) {
//					System.out.println("-1");
//					break;
//				}
//			}
//		}
//		if (five >= 0) {
//			System.out.println(five);
//			System.out.println(three);
//		}
//		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int sugar = Integer.parseInt(br.readLine());
		
		if (sugar==4 ||sugar==7) {
			System.out.println(-1);
		}
		else if (sugar%5==0) {
			System.out.println(sugar/5);
		}
		else if (sugar%5==2 || sugar%5==4) {
			System.out.println((sugar/5)+2);
		}

		else if (sugar%5==1 || sugar%5==3) {
			System.out.println((sugar/5)+1);
		}
		
		
	}

}
