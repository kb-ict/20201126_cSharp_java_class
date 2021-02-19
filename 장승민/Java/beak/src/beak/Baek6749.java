package beak;

import java.util.Scanner;

public class Baek6749 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int a= sc.nextInt();
		int b = sc.nextInt();
		sc.close();
		int gap = b-a;
		int c = b+ gap;
		System.out.println(c);

	}

}
