package beak;

import java.util.Scanner;

public class Beak16430 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int A = sc.nextInt();
		int B = sc.nextInt();
		sc.close();
		if (A%B!=0&&A<B) {
			System.out.print(B-A+" ");
			System.out.print(B);
		}

	}

}
