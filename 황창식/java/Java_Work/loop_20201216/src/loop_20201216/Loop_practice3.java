package loop_20201216;

import java.util.Random;

public class Loop_practice3 {

	public static void main(String[] args) {

		Random rand = new Random();

		System.out.println("---------------------");
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println("---------------------");

		System.out.println("For 문");
		for (int i = 0; i < 6; i++) {
			int num1 = rand.nextInt(45) + 1;
			System.out.print(num1 + " ");
		}
		System.out.println("\n---------------------");

		System.out.println("While 문");
		int i = 0;
		while (i < 6) {
			int num1 = rand.nextInt(45) + 1;
			System.out.print(num1 + " ");
			i++;
		}
		System.out.println("\n---------------------");

		

		System.out.println("Do While 문");
		i = 0;
		do {
			int num1 = rand.nextInt(45) + 1;
			System.out.print(num1 + " ");
			i++;
		} while(i < 6);
		

	}

}
